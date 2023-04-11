using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProbabilityTheory.Classes
{
	internal class DistributionManager
	{
		private const int _normalSelectionNumber = 20;

		private List<double> _uniformSelection;
		private List<double> _normalSelection;
		private List<double> _exponentialSelection;

		private Random _random;

		private DistributionManager()
		{
			_uniformSelection = new List<double>();
			_normalSelection = new List<double>();
			_exponentialSelection = new List<double>();

			_random = new Random();

			UpdateSelection();
		}

		public static DistributionManager Create() => new DistributionManager();

		public void UpdateSelection()
		{
			_uniformSelection.Clear();
			_normalSelection.Clear();

			double randomValuesSum = 0;
			for (int i = 0; i < 20000; i++)
			{
				double randomValue = _random.NextDouble();

				if (i % _normalSelectionNumber == 0)
				{
					_normalSelection.Add(randomValuesSum);
					_uniformSelection.Add(randomValue);

					randomValuesSum = 0;
				}

				randomValuesSum += randomValue;
			}
		}

		public void GetUniformHistogram(Series series, int intervalsAmount)
		{
			series.Points.Clear();
			series.Name = "РАВНОМЕРНОЕ";

			int i = 1;
			double intervalLength = (_uniformSelection.Max() - _uniformSelection.Min()) / intervalsAmount,
				left = 0, right = _uniformSelection.Min() + intervalLength;

			while (right <= _uniformSelection.Max())
			{
				int valuesAmount = _uniformSelection.Count(x => x >= left && x <= right);
				series.Points.AddXY(Math.Round((right + left) / 2, 3), (double)valuesAmount / _uniformSelection.Count / intervalLength);

				left = _uniformSelection.Min() + i * intervalLength;
				right = _uniformSelection.Min() + (++i) * intervalLength;
			}

			if(series.Points.Count != intervalsAmount)
			{
				int valuesAmount = _uniformSelection.Count(x => x >= left && x <= _uniformSelection.Max());
				series.Points.AddXY(Math.Round((_uniformSelection.Max() + left) / 2, 3), (double)valuesAmount / _uniformSelection.Count / intervalLength);
			}
		}

		public void GetNormalHistogram(Series series, int intervalsAmount)
		{
			series.Points.Clear();
			series.Name = "НОРМАЛЬНОЕ";

			int i = 1;
			double intervalLength = (double)_normalSelectionNumber / intervalsAmount,
				left = 0, right = intervalLength;

			while (right <= _normalSelectionNumber)
			{
				int valuesAmount = _normalSelection.Count(x => x >= left && x <= right);
				series.Points.AddXY(Math.Round((right + left) / 2, 3), (double)valuesAmount / _normalSelection.Count / intervalLength);

				left = i * intervalLength;
				right = (++i) * intervalLength;
			}

			if (series.Points.Count != intervalsAmount)
			{
				int valuesAmount = _normalSelection.Count(x => x >= left && x <= _normalSelection.Max());
				series.Points.AddXY(Math.Round((_normalSelection.Max() + left) / 2, 3), (double)valuesAmount / _normalSelection.Count / intervalLength);
			}
		}

		public void GetExponentialHistogram(Series series, double lambda, int intervalsAmount)
		{
			_exponentialSelection.Clear();

			series.Points.Clear();
			series.Name = "ЭКСПОНЕНЦИАЛЬНОЕ";

			for (int j = 0; j < 1000; j++)
				_exponentialSelection.Add(-1f / lambda * Math.Log(_random.NextDouble()));

			int i = 1;
			double intervalLength = (_exponentialSelection.Max() - _exponentialSelection.Min()) / intervalsAmount,
				left = 0, right = _exponentialSelection.Min() + intervalLength;

			while (right <= _exponentialSelection.Max())
			{
				int valuesAmount = _exponentialSelection.Count(x => x >= left && x <= right);
				series.Points.AddXY(Math.Round((right + left) / 2, 3), (double)valuesAmount / _exponentialSelection.Count / intervalLength);

				left = _exponentialSelection.Min() + i * intervalLength;
				right = _exponentialSelection.Min() + (++i) * intervalLength;
			}

			if (series.Points.Count != intervalsAmount)
			{
				int valuesAmount = _exponentialSelection.Count(x => x >= left && x <= _exponentialSelection.Max());
				series.Points.AddXY(Math.Round((_exponentialSelection.Max() + left) / 2, 3), (double)valuesAmount / _exponentialSelection.Count / intervalLength);
			}
		}
	}
}