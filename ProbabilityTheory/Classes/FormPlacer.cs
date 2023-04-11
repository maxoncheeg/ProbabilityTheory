using System.Windows.Forms;

namespace ProbabilityTheory.Classes
{
	internal static class FormPlacer
	{
		public static void ToScreenCenter(Form form) =>
			form.Location = new System.Drawing.Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - form.Width / 2,
				Screen.PrimaryScreen.WorkingArea.Height / 2 - form.Height / 2);
	}
}
