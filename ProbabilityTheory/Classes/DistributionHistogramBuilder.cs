using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProbabilityTheory.Classes
{
	internal class DistributionHistogramBuilder
	{
		private double _intervalLength = 0;

		public Series Histogram { get; private set; }

		private DistributionHistogramBuilder(Series Histogram)
		{
			this.Histogram = Histogram;
			this.Histogram.Points.Clear();
		}

		public static DistributionHistogramBuilder Create(Series series)
		{
			if (series == null) return null;
			return new DistributionHistogramBuilder(series);
		}

		public void BuildHistogram(Selection selection, int intervalsAmount)
		{
			Histogram.Points.Clear();
			Histogram.Name = selection.Name;

			_intervalLength = selection.Range / intervalsAmount;

			List<int> counters = new List<int>();
			for (int i = 0; i < intervalsAmount; i++) counters.Add(0);

			for (int i = 0; i < selection.Values.Count; i++)
			{
				int intervalIndex = (int)Math.Floor(selection.Values[i] / _intervalLength);
				counters[intervalIndex >= counters.Count ? counters.Count - 1 : intervalIndex]++;
			}

			if (selection.Values.Count != 0)
				for (int i = 0; i < intervalsAmount; i++)
				{
					double x = Math.Round(((i + 1) * _intervalLength + i * _intervalLength) / 2, 3),
						   y = (double)counters[i] / selection.Values.Count / _intervalLength;
					Histogram.Points.AddXY(x, y);
				}
		}

		public double GetCurrentMode()
		{
			if(Histogram.Points.Count == 0) return 0;

			double maxY = Histogram.Points[0].YValues[0], XofMaxY = Histogram.Points[0].XValue;
			int indexMax = 0;

			for (int i = 1; i < Histogram.Points.Count; i++)
				if (Histogram.Points[i].YValues[0] > maxY)
				{
					maxY = Histogram.Points[i].YValues[0];
					XofMaxY = Histogram.Points[i].XValue;
					indexMax = i;
				}

			double X1 = XofMaxY - _intervalLength / 2,
				   X2 = XofMaxY + _intervalLength / 2,
				   Y1 = indexMax == 0 ? 0 : Histogram.Points[indexMax - 1].YValues[0],
				   Y2 = indexMax == Histogram.Points.Count - 1 ? 0 : Histogram.Points[indexMax + 1].YValues[0];

			double k1 = (maxY - Y1) / (X2 - X1),
				   b1 = Y1 - X1 * k1,
				   k2 = (maxY - Y2) / (X1 - X2),
				   b2 = Y2 - X2 * k2;

			return (b2 - b1) / (k1 - k2);
		}
	}
}
