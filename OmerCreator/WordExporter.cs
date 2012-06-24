using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
//using Microsoft.Office.Interop.Word.Extensions;
using Microsoft.Office.Interop.Word;
using ShomreiTorah.Common;
using ShomreiTorah.WinForms.Forms;
using System.Globalization;
namespace OmerCreator {
	static class WordExporter {
		static Microsoft.Office.Interop.Word.Application MSWord { get { return Office<ApplicationClass>.App; } }
		public static void Export(int hebrewYear, bool includeנקודות) {
			ProgressWorker.Execute(ui => {
				MSWord.Visible = true;
				var document = MSWord.Documents.Add();

				ui.Caption = "Creating document";

				Range range;
				try {
					MSWord.ScreenUpdating = false;
					document.PageSetup.TopMargin = 13;
					document.PageSetup.BottomMargin = 10;

					range = document.Range();
					range.Font.Name = "Calibri";
					range.Font.NameBi = "David";
					range.Font.Size = 12;
					range.Font.SizeBi = 13;
					range.ParagraphFormat.Space1();

					var bracha = document.Range();
					bracha.InsertAfter("\n");
					if (includeנקודות)
						bracha.Text = "בָּרוּךְ אַתָּה ה' אֱלֹקינוּ מֶלֶךְ הָעוֹלָם אֲשֶׁר קִדְּשָׁנוּ בְּמִצְוֹתָיו וְצִוָּנוּ עַל סְפִירַת הָעוֹמֶר";
					else
						bracha.Text = "ברוך אתה ה' אלקינו מלך העולם אשר קדשנו במצותיו וציונו על ספירת העומר";
					bracha.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
					bracha.ParagraphFormat.SpaceAfter = 2;

					range = document.Range();
					range.Collapse(WdCollapseDirection.wdCollapseEnd);


					var table = document.Tables.Add(range, 49, 3);
					table.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
					table.Range.ParagraphFormat.SpaceAfter = 0;
					table.Columns[1].Width = MSWord.InchesToPoints(.32f);
					table.Columns[2].Width = MSWord.InchesToPoints(2.15f);
					table.Columns[3].Width = MSWord.InchesToPoints(4.5f);

					var border = table.Borders[WdBorderType.wdBorderHorizontal];
					border.LineStyle = WdLineStyle.wdLineStyleSingle;
					border.LineWidth = WdLineWidth.wdLineWidth025pt;
					border.Color = WdColor.wdColorDarkBlue;

					foreach (var side in new[] { WdBorderType.wdBorderTop, WdBorderType.wdBorderRight, WdBorderType.wdBorderBottom, WdBorderType.wdBorderLeft }) {
						border = table.Borders[side];
						border.LineStyle = WdLineStyle.wdLineStyleThickThinMedGap;
						border.LineWidth = WdLineWidth.wdLineWidth150pt;
						border.Color = WdColor.wdColorBlack;
					}
					MSWord.ScreenRefresh();

					ui.Maximum = 49;
					ui.Caption = "Writing chart";
					for (var date = Program.OmerStart(hebrewYear); date.Info.OmerDay != -1; date++) {
						var index = date.Info.OmerDay;
						var text = includeנקודות ? date.Info.OmerTextנקוד : date.Info.OmerText;

						if (ui.WasCanceled) return;

						ui.Progress = index;

						table.Rows[index].Range.Font.Color = (WdColor)ColorTranslator.ToOle(Program.GetColor(index));
						table.Cell(index, 1).Range.Text = index.ToString(CultureInfo.CurrentCulture);
						table.Cell(index, 2).Range.Text = date.EnglishDate.AddDays(-1).ToString("dddd \"night\", MMMM d", CultureInfo.CurrentCulture);
						table.Cell(index, 3).Range.Text = text;
					}
				} finally { MSWord.ScreenUpdating = true; }
				range = document.Range();
				range.Collapse(WdCollapseDirection.wdCollapseEnd);
				//range.Text = String.Format(CultureInfo.CurrentUICulture,
				//    "ספירת העומר for {0} ({1})  |  By Schabse S. Laks",
				//    (hebrewYear - 5000).ToHebrewString(HebrewNumberFormat.LetterQuoted),
				//    Program.OmerStart(hebrewYear).EnglishDate.Year);
				WriteFooter(range, hebrewYear);

				MSWord.Activate();
			}, cancellable: true);
		}
		static void WriteFooter(Range target, int hebrewYear) {
			target.Text = "ספירת העומר for " + (hebrewYear - 5000).ToHebrewString(HebrewNumberFormat.LetterQuoted);
			target.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

			var dividerRange = target.Document.Range(target.End, target.End);

			dividerRange.Text = "l";
			target = target.Document.Range(dividerRange.End, dividerRange.End);
			target.InsertAfter(" (" + Program.OmerStart(hebrewYear).EnglishDate.Year + ")  |  By Schabse S. Laks");

			dividerRange.Font.Size = 1;
			dividerRange.Font.Color = WdColor.wdColorWhite;
		}
	}
}
