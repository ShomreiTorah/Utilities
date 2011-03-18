using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using ShomreiTorah.Common;
using ShomreiTorah.Common.Updates;

namespace ShomreiTorah.UpdatePublisher {
	partial class UpdateDetails : XtraUserControl {
		public UpdateDetails() {
			InitializeComponent();
		}
		public void ShowOldFiles(UpdateInfo oldUpdate, ReadOnlyCollection<string> updateFiles, string newBasePath) {
			caption.Text = "Existing version: " + oldUpdate.NewVersion.ToString();
			descriptionText.Text = String.Format(CultureInfo.CurrentCulture, "Published: {0:F}\r\n\r\n{1}", oldUpdate.PublishDate, oldUpdate.GetChanges(new Version()));
			descriptionText.Properties.ReadOnly = true;

			var filesData = new List<TreeFile>(oldUpdate.Files.Select(uf => new TreeFile(uf, updateFiles, newBasePath)).OrderBy(tf => tf.Name));

			filesData.AddRange(
				GetFolders(filesData.Select(f => f.FullPath))
					.Select(d => new TreeFile(d, isFolder: true))
					.OrderBy(tf => tf.Name)
			);

			files.RootValue = "/";
			files.DataSource = filesData;
			files.ExpandAll();
		}
		static IEnumerable<string> GetFolders(IEnumerable<string> fileNames) {
			//Recursively crawl up each path to add
			//all folders.  We need the loop to get
			//folders which have subfolders but not
			//files.
			var allFolders = new HashSet<string>();

			//Gather the unique parent folders.  We
			//can reach the same folder in multiple
			//iterations if it has multiple levels 
			//of nesting.
			IEnumerable<string> parentFolders = fileNames;
			do {
				parentFolders = parentFolders.Select(Path.GetDirectoryName)
											 .Where(p => !String.IsNullOrEmpty(p))
											 .ToList();	//We're about to add this to allFolders, so I need to materialize it.
				allFolders.UnionWith(parentFolders);
			} while (parentFolders.Any());				//The query was already materialized, so this is OK.
			return allFolders;
		}

		public void ShowNewFiles(Version version, string description, ReadOnlyCollection<string> updateFiles, string basePath, UpdateInfo oldUpdate) {
			caption.Text = "New version: " + version.ToString();
			descriptionText.Text = description;
			descriptionText.Properties.ReadOnly = false;

			//If there are old files, set everything to Added, then refine later.
			int defaultState = (int)(oldUpdate == null ? FileState.None : FileState.Added);

			var filesData = new List<TreeFile>(
				updateFiles
					.Select(p => new TreeFile(p, isFolder: false) { State = defaultState })
					.OrderBy(tf => tf.Name)
			);

			if (oldUpdate != null) {
				foreach (var oldFile in oldUpdate.Files) {
					var newPath = Path.Combine(basePath, oldFile.RelativePath);

					var newFile = filesData.FirstOrDefault(f => f.FullPath.Equals(newPath, StringComparison.OrdinalIgnoreCase));
					if (newFile == null) continue;

					if (oldFile.Matches(basePath))
						newFile.State = (int)FileState.Identical;
					else
						newFile.State = (int)FileState.Changed;
				}
			}

			//The directories must be added after setting the State properties so I don't set their's too.
			filesData.AddRange(Directory.EnumerateDirectories(basePath, "*.*", SearchOption.AllDirectories).Select(p => new TreeFile(p, isFolder: true)));

			files.RootValue = basePath;
			files.DataSource = filesData;
			files.ExpandAll();
		}

		protected override void OnVisibleChanged(EventArgs e) {
			base.OnVisibleChanged(e);
			files.BestFitColumns();
		}

		public string Description { get { return descriptionText.Text; } }

		sealed class TreeFile {
			public TreeFile(UpdateFile uf, ReadOnlyCollection<string> updateFiles, string newBasePath) {
				FullPath = uf.RelativePath.Replace('/', '\\');
				Size = uf.Length;

				if (!updateFiles.Contains(Path.Combine(newBasePath, uf.RelativePath), StringComparer.OrdinalIgnoreCase))
					State = (int)FileState.Deleted;
				else if (uf.Matches(newBasePath))
					State = (int)FileState.Identical;
				else
					State = (int)FileState.Changed;
			}
			public TreeFile(string path, bool isFolder) {
				FullPath = path.Replace('/', '\\');

				if (isFolder)
					Size = -1;
				else
					Size = new FileInfo(FullPath).Length;
			}

			[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Data Binding")]
			public string ParentDirectory {
				get {
					var retVal = Path.GetDirectoryName(FullPath);
					if (String.IsNullOrEmpty(retVal))
						return "/";
					return retVal;
				}
			}
			public string Name { get { return Path.GetFileName(FullPath); } }
			[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Data Binding")]
			public string Extension { get { return Path.GetExtension(FullPath); } }

			[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Data Binding")]
			public int State { get; set; }

			public string FullPath { get; private set; }
			public long Size { get; private set; }
			public string SizeString { get { return Size == -1 ? "" : ToSizeString(Size); } }

			public override string ToString() {	//For debugging
				if (Size < 0)
					return "(folder:) " + FullPath;
				return FullPath;

			}
		}
		enum FileState {
			None,
			Identical,
			Changed,
			Added,
			Deleted
		}
		static string ToSizeString(double bytes) {
			var culture = CultureInfo.CurrentCulture;
			const string format = "#,0.0";

			if (bytes < 1024)
				return bytes.ToString("#,0", culture) + " bytes";
			bytes /= 1024;
			if (bytes < 1024)
				return bytes.ToString(format, culture) + " KB";
			bytes /= 1024;
			if (bytes < 1024)
				return bytes.ToString(format, culture) + " MB";
			bytes /= 1024;
			return bytes.ToString(format, culture) + " GB";
		}

		Dictionary<string, int> loadedIcons = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

		private void files_GetStateImage(object sender, GetStateImageEventArgs e) {
			var file = files.GetDataRecordByNode(e.Node) as TreeFile;

			int index;

			if (!loadedIcons.TryGetValue(file.FullPath, out index)) {
				Icon icon;
				if (file.Size < 0 && !Directory.Exists(file.FullPath))	//Handle non-existant directories in the current (old) version tree.
					icon = IconReader.GetFolderIcon(IconSize.Small, FolderType.Open);
				else
					icon = IconReader.GetPathIcon(file.FullPath, IconSize.Small, false);

				using (icon)
					index = loadedIcons[file.FullPath] = icons.Images.Add(icon.ToBitmap());
			}
			e.NodeImageIndex = index;
		}

		private void files_GetNodeDisplayValue(object sender, GetNodeDisplayValueEventArgs e) {
			if (e.Column == colSize)
				e.Value = (files.GetDataRecordByNode(e.Node) as TreeFile).SizeString;
		}

		private void descriptionText_KeyUp(object sender, KeyEventArgs e) {
			if (!descriptionText.Properties.ReadOnly && e.KeyData == (Keys.Enter | Keys.Control))
				SendKeys.Send("  • ");
		}
	}
	enum UpdateKind {
		Old, New
	}
}
