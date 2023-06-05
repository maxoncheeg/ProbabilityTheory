using System;

namespace ProbabilityTheory.Classes
{
	internal class Hypothesis
	{
		public bool IsCorrect { get; private set; }
		public double DistributionFunctionValue { get; private set; }
		public double TheoryFunctionValue { get; private set; }

		private Hypothesis(double DistributionFunctionValue, double TheoryFunctionValue)
		{
			this.DistributionFunctionValue = DistributionFunctionValue;
			this.TheoryFunctionValue = TheoryFunctionValue;
			IsCorrect = DistributionFunctionValue <= TheoryFunctionValue;
		}

		public static Hypothesis KolmogorovHypothesis(ExponentialSelection selection, double alpha, int kolmogogovN = 5)
		{
			if (selection == null) return null;
			else if(alpha <= 0 || alpha >= 1) return null;

			double D,
				   Dleft = double.MinValue, 
				   Dright = double.MinValue;

			selection.Values.Sort();

			int i = 1;
			foreach (double x in selection.Values)
			{
				double f = 1f - Math.Exp(-selection.Lambda * x);

				if ((double)i / (double)selection.Values.Count - f > Dleft)
					Dleft = (double)i / (double)selection.Values.Count - f;
				if (f - (double)(i - 1) / (double)selection.Values.Count > Dright)
					Dright = f - (double)(i - 1) / (double)selection.Values.Count;

				i++;
			}

			D = Math.Max(Dleft, Dright);
			double distributionLambda = D * Math.Sqrt(selection.Values.Count),
				distributionFunctionValue = Selection.GetKolmogorovValue(distributionLambda, kolmogogovN),
				theoryFunctionValue = 1f - alpha;

			return new Hypothesis(distributionFunctionValue, theoryFunctionValue);
		}
	}
}
