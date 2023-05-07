using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityTheory.Classes
{
	internal class ConfidenceInterval
	{
		static Application excel = new Application();

		public double LeftBoundary { get; private set; }
		public double RightBoundary { get; private set; }
		public double Gamma { get; private set; }
		public Selection Selection { get; private set; }

		private ConfidenceInterval(double LeftBoundary, double RightBoundary)
		{
			this.LeftBoundary = LeftBoundary;
			this.RightBoundary = RightBoundary;
		}

		public static ConfidenceInterval Expectation(Selection selection, double gamma)
		{
			//Application excel = new Application();

			double alpha = 1f - gamma,
				t = excel.WorksheetFunction.TInv(alpha / 2, selection.Values.Count - 1),
				avgX = selection.Values.Average(),
				s = Math.Sqrt(selection.Values.Sum((x) => Math.Pow(x - avgX, 2)) / (selection.Values.Count - 1)),
				delta = t * s / Math.Sqrt(selection.Values.Count);

			return new ConfidenceInterval(avgX - delta, avgX + delta) { Selection = selection, Gamma = gamma };
		}

		public static ConfidenceInterval ExpectationByVariance(Selection selection, double gamma, double variance)
		{
			//Application excel = new Application();

			double z = excel.WorksheetFunction.Norm_S_Inv((1f + gamma) / 2),
				delta = z * Math.Sqrt(variance / selection.Values.Count),
				avgX = selection.Values.Average();

			return new ConfidenceInterval(avgX - delta, avgX + delta) { Selection = selection, Gamma = gamma };
		}

		public static ConfidenceInterval Variance(Selection selection, double gamma)
		{
			//Application excel = new Application();

			double alpha = 1f - gamma,
				xi1 = excel.WorksheetFunction.ChiSq_Inv(1f - alpha / 2, selection.Values.Count - 1),
				xi2 = excel.WorksheetFunction.ChiSq_Inv(alpha / 2, selection.Values.Count - 1),
				avgX = selection.Values.Average(),
				sCube = selection.Values.Sum((x) => Math.Pow(x - avgX, 2)) / (selection.Values.Count - 1);

			return new ConfidenceInterval(sCube * (selection.Values.Count - 1) / xi1, sCube * (selection.Values.Count - 1) / xi2) { Selection = selection, Gamma = gamma };
		}

		public static ConfidenceInterval VarianceByExpectation(Selection selection, double gamma, double expectation)
		{
			//Application excel = new Application();

			double alpha = 1f - gamma,
				xi1 = excel.WorksheetFunction.ChiSq_Inv(1f - alpha / 2, selection.Values.Count - 1),
				xi2 = excel.WorksheetFunction.ChiSq_Inv(alpha / 2, selection.Values.Count - 1),
				avgX = selection.Values.Average(),
				variance = selection.Values.Sum((x) => Math.Pow(x - expectation, 2)) / selection.Values.Count;

			return new ConfidenceInterval(variance* selection.Values.Count / xi1, variance * selection.Values.Count / xi2) { Selection = selection, Gamma = gamma };
		}
	}
}
