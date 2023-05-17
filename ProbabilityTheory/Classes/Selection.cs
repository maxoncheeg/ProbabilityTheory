using System;
using System.Collections.Generic;
using System.Linq;

namespace ProbabilityTheory.Classes
{
	internal class Selection
	{
		public List<double> Values { get; private set; }
		public double Expectation { get; private set; }
		public double Variance { get; private set; }
		public double Median { get; private set; }
		public string Name { get; protected set; }


		protected Selection(List<double> Values) 
		{ 
			this.Values = Values;
			CalculateProperties();
		}

		public static Selection GetUniformSelection(int selectionSize)
		{
			Random _random = new Random();
			List<double> values = new List<double>();

			for (int i = 0; i < selectionSize; i++)
				values.Add(_random.NextDouble());

			return new Selection(values) { Name = "Равномерное" };
		}

		public static Selection GetNormalSelection(int selectionSize, int randomValuesAmount)
		{
			Random _random = new Random();
			List<double> values = new List<double>();

			for (int i = 0; i < selectionSize; i++)
			{
				double value = 0;
				for (int j = 0; j < randomValuesAmount; j++)
					value += _random.NextDouble();
				values.Add(value);
			}

			return new Selection(values) { Name = "Нормальное" };
		}

		public static Selection GetNormalSelection(int selectionSize, int randomValuesAmount, double expectation, double deviation)
		{
			Random _random = new Random();
			List<double> values = new List<double>();

			for (int i = 0; i < selectionSize; i++)
			{
				double value = 0;
				for (int j = 0; j < randomValuesAmount; j++)
					value += _random.NextDouble();

				double z = (value - randomValuesAmount / 2) / Math.Sqrt(randomValuesAmount / 12),
					   x = z * deviation + expectation;

				values.Add(x);
			}

			return new Selection(values) { Name = "Нормальное с параметрами" };
		}

		public static double GetKolmogorovValue(double x, int n)
		{
			double lambda = 0;
			for (int k = -n; k <= n; k++)
				lambda += Math.Pow(-1, k)* Math.Exp(-2f * Math.Pow(k * x, 2));

			return lambda < 0 ? 0 : lambda;
		}

		public static double GetExponentialDensityValue(double x, double lambda)
		{
			return lambda * Math.Exp(-lambda * x);
		}

		private void CalculateProperties() 
		{
			Expectation = Values.Average();
			Variance = Values.Sum(x => Math.Pow(x - Expectation, 2)) / Values.Count;
			Values.Sort();

			if (Values.Count % 2 == 0)
				Median = (Values[Values.Count / 2] + Values[Values.Count / 2 - 1]) / 2;
			else
				Median = Values[Values.Count / 2];
		}
	}
}
