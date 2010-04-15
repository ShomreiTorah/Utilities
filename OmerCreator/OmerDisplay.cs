using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShomreiTorah.Common.Calendar.Holidays;
using System.Globalization;

namespace OmerCreator {
	public partial class OmerDisplay : Form {
		static readonly Font omerFont = new Font("David", 14);


		public OmerDisplay(int hebrewYear, bool includeנקודות) {
			InitializeComponent();
			text.Font = omerFont;
			text.SelectionTabs = new[] { 40, 280 };
			text.SelectionAlignment = HorizontalAlignment.Center;
			if (includeנקודות)
				text.Text = "בָּרוּךְ אַתָּה ה' אֱלֹקינוּ מֶלֶךְ הָעוֹלָם אֲשֶׁר קִדְּשָׁנוּ בְּמִצְוֹתָיו וְצִוָּנוּ עַל סְפִירַת הָעוֹמֶר\r\n\r\n";
			else
				text.Text = "ברוך אתה ה' אלקינו מלך העולם אשר קדשנו במצותיו וציונו על ספירת העומר\r\n\r\n";

			for (var date = Program.OmerStart(hebrewYear); date.Info.OmerDay != -1; date++) {
				text.Select(text.Text.Length, 0);
				text.SelectionAlignment = HorizontalAlignment.Left;
				text.SelectionColor = Program.GetColor(date.Info.OmerDay);
				text.SelectedText = String.Format(CultureInfo.CurrentCulture, "{0}\t{1:dddd \"night\", MMMM d}\t{2}\r\n",
						date.Info.OmerDay, date.EnglishDate.AddDays(-1), (includeנקודות ? date.Info.OmerTextנקוד : date.Info.OmerText));
			}
			text.Select(0, 0);
		}
	}
}
