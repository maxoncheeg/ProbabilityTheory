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

		public static Hypothesis KolmogorovHypothesis(ExponentialSelection selection, int superpower)
		{
			if (selection == null) return null;

			double Dp = 0, Xp = 0,
				   Dm = 0, Xm =0;

			selection.Values.Sort();
			int i = 1, Kp = 0, Km = 0;
			foreach (double x in selection.Values)
			{
				double F = 1f - Math.Exp(-selection.Lambda * x);
				double temp = Math.Abs((double)i / (double)selection.Values.Count - F);

				if (temp  > Dp)
				{
					Dp = temp < 0 ? temp * -1 : temp;
					Xp = x;
					Kp = i;
				}
				temp = Math.Abs((double)(i - 1) / (double)selection.Values.Count - F);
				if (temp > Dm)
				{
					Dm = temp < 0 ? temp * -1 : temp;
					Xm = x;
					Km = i;
				}

				i++;
			}


			double D = Math.Max(Dp, Dm),
				   X = D == Dp ? Xp : Xm,
				   K = D == Dp ? Kp : Km;

			double lambda = D*Math.Sqrt(selection.Values.Count),
				   theoryLambda = Selection.GetKolmogorovValue(X, 5);

			return new Hypothesis(lambda, theoryLambda) { XValue = X };
		}
	}
}
