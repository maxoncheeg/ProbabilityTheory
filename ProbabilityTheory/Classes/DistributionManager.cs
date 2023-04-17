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

			UpdateSelection(_selectionSize);
		}

		public static DistributionManager Create() => new DistributionManager();

		public void UpdateSelection(int selectionSize)
		{
			_uniformSelection.Clear();
			_normalSelection.Clear();

			double randomValuesSum = 0;
			for (int i = 0; i < _normalSelectionNumber * selectionSize; i++)
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

			for (int i = 0; i < intervalsAmount; i++)
			{
				double x = Math.Round(((i + 1) * intervalLength + i * intervalLength) / 2, 3),
					   y = (double)counters[i] / _uniformSelection.Count / intervalLength;
				series.Points.AddXY(x, y);
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

			for (int i = 0; i < intervalsAmount; i++)
			{
				double x = Math.Round(((i + 1) * intervalLength + i * intervalLength) / 2, 3),
					   y = (double)counters[i] / _normalSelection.Count / intervalLength;
				series.Points.AddXY(x, y);
			}
		}

		public void GetExponentialHistogram(Series series, double lambda, int intervalsAmount)
		{
			_exponentialSelection.Clear();
			series.Points.Clear();
			series.Name = "ЭКСПОНЕНЦИАЛЬНОЕ";

			for (int j = 0; j < _selectionSize; j++)
				_exponentialSelection.Add(-1f / lambda * Math.Log(_random.NextDouble()));

			double intervalLength = (_exponentialSelection.Max() - _exponentialSelection.Min()) / intervalsAmount;
			List<int> counters = new List<int>();

			for (int i = 0; i < intervalsAmount; i++) counters.Add(0);

			for (int i = 0; i < _exponentialSelection.Count; i++)
			{
				int intervalIndex = (int)Math.Floor(_exponentialSelection[i] / intervalLength);
				counters[intervalIndex >= counters.Count ? counters.Count - 1 : intervalIndex]++;
			}

			for (int i = 0; i < intervalsAmount; i++)
			{
				double x = Math.Round(((i + 1) * intervalLength + i * intervalLength) / 2, 3),
					   y = (double)counters[i] / _exponentialSelection.Count / intervalLength;
				series.Points.AddXY(x, y);
			}
		}
	}
}