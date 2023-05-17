using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProbabilityTheory.Classes
{
	internal class Hypothesis
	{
		public double DistributionLambda { get; private set; }
		public double TheoryLambda { get; private set; }
		public double XValue { get; private set; }

		private Hypothesis(double DistributionLambda, double TheoryLambda)
		{
			this.DistributionLambda = DistributionLambda;
			this.TheoryLambda = TheoryLambda;
		}

		public static Hypothesis KolmogorovHypothesis(ExponentialSelection selection, int intervals)
		{
			if (selection == null) return null;

			Series series = new Series();
			DistributionHistogramBuilder builder = DistributionHistogramBuilder.Create(series);

			builder.BuildHistogram(selection, intervals);

			double Dp = 0, Xp = 0,
				   Dm = 0, Xm =0;

			//int i = 0;

			//foreach (DataPoint point in series.Points)
			//{
			//	double F = Selection.GetExponentialDensityValue(point.XValue, selection.Lambda);

			//	if (i / series.Points.Count - F > Dp)
			//	{
			//		Dp = i / series.Points.Count - F;
			//		Xp = point.XValue;
			//	}

			//	if (F - (i - 1) / series.Points.Count > Dm)
			//	{
			//		Dm = F - (i - 1) / series.Points.Count;
			//		Xm = point.XValue;
			//	}

			//	i++;
			//}


			foreach (DataPoint point in series.Points)
			{
				double temp = point.YValues[0] - Selection.GetExponentialDensityValue(point.XValue, selection.Lambda);
				if(Dp < temp)
				{
					Dp = temp;
					Xp = point.XValue;
				}
			}

			double D = Math.Max(Dp, Dm), 
				   X = D == Dp ? Xp : Xm;

			double lambda = D*Math.Sqrt(intervals),
				   theoryLambda = Selection.GetKolmogorovValue(X, 5);

			return new Hypothesis(lambda, theoryLambda) { XValue = X };
		}
	}
}
