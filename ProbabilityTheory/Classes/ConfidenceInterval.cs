using Microsoft.Office.Interop.Excel;
using System;
using System.Linq;

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
			double alpha = 1f - gamma,//ищем а, уровень значимости
				t = excel.WorksheetFunction.TInv(alpha / 2, selection.Values.Count - 1),//получаем квантиль
				avgX = selection.Values.Average(), // считаем среднее значение выборки
				s = Math.Sqrt(selection.Values.Sum((x) => Math.Pow(x - avgX, 2)) / (selection.Values.Count - 1)), // считаем исправленную выборочную дисперсию
				delta = t * s / Math.Sqrt(selection.Values.Count); // считаем дельту

			return new ConfidenceInterval(avgX - delta, avgX + delta) { Selection = selection, Gamma = gamma };//возвращаем интервал.
		}

		public static ConfidenceInterval ExpectationByVariance(Selection selection, double gamma, double variance)
		{
			double z = excel.WorksheetFunction.Norm_S_Inv((1f + gamma) / 2),//получаем квантиль
				delta = z * Math.Sqrt(variance / selection.Values.Count),//считаем дельту
				avgX = selection.Values.Average();//считаем среднее значение выборки

			return new ConfidenceInterval(avgX - delta, avgX + delta) { Selection = selection, Gamma = gamma };//возвращаем интервал
		}

		public static ConfidenceInterval Variance(Selection selection, double gamma)
		{
			double alpha = 1f - gamma,//уровень значимости
				xi1 = excel.WorksheetFunction.ChiSq_Inv(1f - alpha / 2, selection.Values.Count - 1),//квантиль для левой границы
				xi2 = excel.WorksheetFunction.ChiSq_Inv(alpha / 2, selection.Values.Count - 1),//квантиль для правой границы
				avgX = selection.Values.Average(),//среднее значение выборки
				sCube = selection.Values.Sum((x) => Math.Pow(x - avgX, 2)) / (selection.Values.Count - 1);//исправленная выборочная дисперсия

			return new ConfidenceInterval(sCube * (selection.Values.Count - 1) / xi1, sCube * (selection.Values.Count - 1) / xi2) { Selection = selection, Gamma = gamma };
		}

		public static ConfidenceInterval VarianceByExpectation(Selection selection, double gamma, double expectation)
		{
			double alpha = 1f - gamma,//уровень значимости
				xi1 = excel.WorksheetFunction.ChiSq_Inv(1f - alpha / 2, selection.Values.Count),//квантиль для левой границы
				xi2 = excel.WorksheetFunction.ChiSq_Inv(alpha / 2, selection.Values.Count),//квантиль для правой границы
				variance = selection.Values.Sum((x) => Math.Pow(x - expectation, 2)) / selection.Values.Count; //выборочная дисперсия
			return new ConfidenceInterval(variance * selection.Values.Count / xi1, variance * selection.Values.Count / xi2) { Selection = selection, Gamma = gamma };
		}
	}
}
