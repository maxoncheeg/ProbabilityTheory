using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProbabilityTheory.Classes
{
	internal class DistributionManager
	{
		private const int _normalSelectionNumber = 20;
		private int _selectionSize = 1000;

		private readonly List<double> _uniformSelection;
		private readonly List<double> _normalSelection;
		private readonly List<double> _exponentialSelection;

		private readonly Random _random;

		public double Expectation { get; private set; }
		public double Variance { get; private set; }
		public double Mode { get; private set; }
		public double Median { get; private set; }

		private DistributionManager()
		{
			_uniformSelection = new List<double>();
			_normalSelection = new List<double>();
			_exponentialSelection = new List<double>();

			_random = new Random();

			UpdateSelection(_selectionSize);
		}

		public static DistributionManager Create() => new DistributionManager();

		public void UpdateSelection(int selectionSize, double lambda = 0.1f)
		{
			if (lambda < 0.1f) lambda = 0.1f;
			else if (selectionSize < 0) selectionSize = 0;

			_uniformSelection.Clear();
			_normalSelection.Clear();
			_exponentialSelection.Clear();

			double randomValuesSum = 0;
			for (int i = 0; i < _normalSelectionNumber * selectionSize; i++)
			{
				double randomValue = _random.NextDouble();

				if (i % _normalSelectionNumber == 0)
				{
					_normalSelection.Add(randomValuesSum);
					_uniformSelection.Add(randomValue);
					_exponentialSelection.Add(-1f / lambda * Math.Log(randomValue));

					randomValuesSum = 0;
				}

				randomValuesSum += randomValue;
			}

			_selectionSize = selectionSize;
		}

		public void GetUniformHistogram(Series series, int intervalsAmount)
		{
			series.Points.Clear();
			series.Name = "РАВНОМЕРНОЕ";

			double intervalLength = 1f / intervalsAmount;
			List<int> counters = new List<int>();

			for (int i = 0; i < intervalsAmount; i++) counters.Add(0);

			for (int i = 0; i < _uniformSelection.Count; i++)
			{
				int intervalIndex = (int)Math.Floor(_uniformSelection[i] / intervalLength);
				counters[intervalIndex >= counters.Count ? counters.Count - 1 : intervalIndex]++;
			}

			if (_uniformSelection.Count != 0)
			{
				for (int i = 0; i < intervalsAmount; i++)
				{
					double x = Math.Round(((i + 1) * intervalLength + i * intervalLength) / 2, 3),
						   y = (double)counters[i] / _uniformSelection.Count / intervalLength;
					series.Points.AddXY(x, y);
				}

				Mode = GetMode(series, intervalLength);
				UpdateValues(_uniformSelection);
			}
		}

		public void GetNormalHistogram(Series series, int intervalsAmount)
		{
			series.Points.Clear();
			series.Name = "НОРМАЛЬНОЕ";

			double intervalLength = (double)_normalSelectionNumber / intervalsAmount;
			List<int> counters = new List<int>();

			for (int i = 0; i < intervalsAmount; i++) counters.Add(0);

			for (int i = 0; i < _normalSelection.Count; i++)
			{
				int intervalIndex = (int)Math.Floor(_normalSelection[i] / intervalLength);
				counters[intervalIndex >= counters.Count ? counters.Count - 1 : intervalIndex]++;
			}

			if (_normalSelection.Count != 0)
			{
				for (int i = 0; i < intervalsAmount; i++)
				{
					double x = Math.Round(((i + 1) * intervalLength + i * intervalLength) / 2, 3),
						   y = (double)counters[i] / _normalSelection.Count / intervalLength;
					series.Points.AddXY(x, y);
				}

				Mode = GetMode(series, intervalLength);
				UpdateValues(_normalSelection);
			}
		}

		public void GetExponentialHistogram(Series series, int intervalsAmount)
		{
			series.Points.Clear();
			series.Name = "ЭКСПОНЕНЦИАЛЬНОЕ";

			double intervalLength = (_exponentialSelection.Max() - _exponentialSelection.Min()) / intervalsAmount;
			List<int> counters = new List<int>();

			for (int i = 0; i < intervalsAmount; i++) counters.Add(0);

			for (int i = 0; i < _exponentialSelection.Count; i++)
			{
				int intervalIndex = (int)Math.Floor(_exponentialSelection[i] / intervalLength);
				counters[intervalIndex >= counters.Count ? counters.Count - 1 : intervalIndex]++;
			}

			if (_exponentialSelection.Count != 0)
			{
				for (int i = 0; i < intervalsAmount; i++)
				{
					double x = Math.Round(((i + 1) * intervalLength + i * intervalLength) / 2, 3),
						   y = (double)counters[i] / _exponentialSelection.Count / intervalLength;
					series.Points.AddXY(x, y);
				}

				Mode = GetMode(series, intervalLength);
				UpdateValues(_exponentialSelection);
			}
		}

		private void UpdateValues(List<double> selection)
		{
			Expectation = selection.Average();
			Variance = selection.Sum(x => Math.Pow(x - Expectation, 2)) / selection.Count;
			selection.Sort();
			
			if(selection.Count % 2 == 0)
				Median = (selection[selection.Count / 2] + selection[selection.Count / 2 - 1]) / 2;
			else
				Median = selection[selection.Count / 2];
		}

		private static double GetMode(Series series, double intervalLength)
		{
			double maxY = series.Points[0].YValues[0], XofMaxY = series.Points[0].XValue;
			int indexMax = 0;

			for (int i = 1; i < series.Points.Count; i++)
				if(series.Points[i].YValues[0] > maxY)
				{
					maxY = series.Points[i].YValues[0];
					XofMaxY = series.Points[i].XValue;
					indexMax = i;
				}

			double X1 = XofMaxY - intervalLength / 2,
				   X2 = XofMaxY + intervalLength / 2,
				   Y1 = indexMax == 0 ? 0 : series.Points[indexMax - 1].YValues[0],
				   Y2 = indexMax == series.Points.Count - 1 ? 0 : series.Points[indexMax + 1].YValues[0];

			double k1 = (maxY - Y1) / (X2 - X1),
				   b1 = Y1 - X1 * k1,
				   k2 = (maxY - Y2) / (X1 - X2),
				   b2 = Y2 - X2 * k2;

			return (b2 - b1) / (k1 - k2);
		}
	}
}