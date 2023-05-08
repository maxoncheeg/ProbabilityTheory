using System;
using System.Linq;
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
			if (intervalsAmount <= 0 || selection == null) return;

			Histogram.Points.Clear();
			Histogram.Name = selection.Name;
			double min = selection.Values.Min();
			_intervalLength = (selection.Values.Max() - min) / intervalsAmount;
			double right = min + _intervalLength;

			for (int i = 0, counter = 0; i < selection.Values.Count; i++, counter++)
			{
				if (selection.Values[i] > right || i + 1 == selection.Values.Count)
				{
					double x = Math.Round(right - _intervalLength / 2, 3),
						   y = (double)counter / selection.Values.Count / _intervalLength;
					Histogram.Points.AddXY(x, y);

					counter = 0;
					right += _intervalLength;
				}
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
