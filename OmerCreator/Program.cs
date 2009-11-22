using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using ShomreiTorah.Common.Calendar;
using ShomreiTorah.Common.Calendar.Holidays;

namespace OmerCreator {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new UI());
		}

		static readonly Color[] weekColors = new[] { Color.Red, Color.Green, Color.Blue, Color.Goldenrod, Color.Purple, Color.Teal, Color.DarkGray };
		public static Color GetColor(int day) {
			if (day < 1 || day > 49) throw new ArgumentOutOfRangeException("day");
			day--;
			return ControlPaint.Dark(weekColors[day / 7], (day % 7) / 12f);
		}

		public static HebrewDate OmerStart(int hebrewYear) { return Holiday.פסח[2].Date.GetDate(hebrewYear); }
	}
}
