using ProbabilityTheory.Classes;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProbabilityTheory.Forms
{
	public partial class FormIntervals : Form
	{
		Microsoft.Office.Interop.Excel.Application _application;
		public FormIntervals()
		{
			InitializeComponent();

			_application = new Microsoft.Office.Interop.Excel.Application();

			buttonCalculate.Click += OnCalculateClick;
			Load += FormIntervals_Load;
		}

		private void FormIntervals_Load(object sender, EventArgs e)
		{
			FormPlacer.ToScreenCenter(this);
		}

		private string ConvertToString(ConfidenceInterval interval) => $"N={interval.Selection.Values.Count} Gamma={interval.Gamma} ({Math.Round(interval.LeftBoundary, 2)}; {Math.Round(interval.RightBoundary, 2)})";

		private void OnCalculateClick(object sender, EventArgs e)
		{
			DistributionHistogramBuilder builderB = DistributionHistogramBuilder.Create(chartHistogramBig.Series[0]);
			DistributionHistogramBuilder builderS = DistributionHistogramBuilder.Create(chartHistogramSmall.Series[0]);

			double deviation = (double)numericUpDownDeviation.Value,
				expectation = (double)numericUpDownExpectation.Value;
			Selection selectionBig = Selection.GetNormalSelection(500, 24, expectation, deviation);
			Selection selectionSmall = Selection.GetNormalSelection(50, 24, expectation, deviation);

			builderB.BuildHistogram(selectionBig, (int)(1 + 3.322 * Math.Log10(selectionBig.Values.Count)));
			builderS.BuildHistogram(selectionSmall, (int)(1 + 3.322 * Math.Log10(selectionSmall.Values.Count)));

			chartHistogramBig.Series[0].Name = "N = 500";
			chartHistogramSmall.Series[0].Name = "N = 50";

			using (StreamWriter writer = new StreamWriter("confidence-intervals.txt", false))
			{
				writer.WriteLine($"m={(double)numericUpDownExpectation.Value}, d={(double)numericUpDownDeviation.Value}");

				writer.WriteLine("Доверительные интервалы мат. ожидания");
				writer.WriteLine("При известной дисперсии");
				writer.WriteLine(ConvertToString(ConfidenceInterval.ExpectationByVariance(selectionBig, 0.95, deviation * deviation)));
				writer.WriteLine(ConvertToString(ConfidenceInterval.ExpectationByVariance(selectionBig, 0.85, deviation * deviation)));
				writer.WriteLine(ConvertToString(ConfidenceInterval.ExpectationByVariance(selectionSmall, 0.95, deviation * deviation)));
				writer.WriteLine(ConvertToString(ConfidenceInterval.ExpectationByVariance(selectionSmall, 0.85, deviation * deviation)));

				writer.WriteLine("При неизвестной дисперсии");
				writer.WriteLine(ConvertToString(ConfidenceInterval.Expectation(selectionBig, 0.95)));
				writer.WriteLine(ConvertToString(ConfidenceInterval.Expectation(selectionBig, 0.85)));
				writer.WriteLine(ConvertToString(ConfidenceInterval.Expectation(selectionSmall, 0.95)));
				writer.WriteLine(ConvertToString(ConfidenceInterval.Expectation(selectionSmall, 0.85)));

				writer.WriteLine("");
				writer.WriteLine("Доверительные интервалы дисперсии");
				writer.WriteLine("При известном мат. ожидании");
				writer.WriteLine(ConvertToString(ConfidenceInterval.VarianceByExpectation(selectionBig, 0.95, expectation)));
				writer.WriteLine(ConvertToString(ConfidenceInterval.VarianceByExpectation(selectionBig, 0.85, expectation)));
				writer.WriteLine(ConvertToString(ConfidenceInterval.VarianceByExpectation(selectionSmall, 0.95, expectation)));
				writer.WriteLine(ConvertToString(ConfidenceInterval.VarianceByExpectation(selectionSmall, 0.85, expectation)));

				writer.WriteLine("При неизвестном мат. ожидании");
				writer.WriteLine(ConvertToString(ConfidenceInterval.Variance(selectionBig, 0.95)));
				writer.WriteLine(ConvertToString(ConfidenceInterval.Variance(selectionBig, 0.85)));
				writer.WriteLine(ConvertToString(ConfidenceInterval.Variance(selectionSmall, 0.95)));
				writer.WriteLine(ConvertToString(ConfidenceInterval.Variance(selectionSmall, 0.85)));

				writer.WriteLine("");
				writer.WriteLine("Распечатки выборок");
				writer.WriteLine("N=500:");
				foreach (double x in selectionBig.Values)
					writer.Write($"{Math.Round(x, 3)} ");
				writer.WriteLine("");
				writer.WriteLine("N=50:");
				foreach (double x in selectionSmall.Values)
					writer.Write($"{Math.Round(x, 3)} ");
				writer.WriteLine("");
			}

			System.Diagnostics.Process.Start("confidence-intervals.txt");
		}
	}
}
