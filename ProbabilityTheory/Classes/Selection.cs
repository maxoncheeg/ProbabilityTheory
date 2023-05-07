using System;
using System.Collections.Generic;
using System.Linq;

namespace ProbabilityTheory.Classes
{
	internal class Selection
	{
		public List<double> Values { get; private set; }
		public double Range { get; private set; }
		public double Expectation { get; private set; }
		public double Variance { get; private set; }
		public double Median { get; private set; }
		public string Name { get; private set; }


		private Selection(List<double> Values, double Range) 
		{ 
			this.Values = Values;
			this.Range = Range;

			CalculateProperties();
		}

		public static Selection GetUniformSelection(int selectionSize)
		{
			Random _random = new Random();
			List<double> values = new List<double>();
			double range = 1f;

			for (int i = 0; i < selectionSize; i++)
				values.Add(_random.NextDouble());

			return new Selection(values, range) { Name = "Равномерное" };
		}

		public static Selection GetNormalSelection(int selectionSize, int randomValuesAmount)
		{
			Random _random = new Random();
			List<double> values = new List<double>();
			double range = randomValuesAmount;

			for (int i = 0; i < selectionSize; i++)
			{
				double value = 0;
				for (int j = 0; j < randomValuesAmount; j++)
					value += _random.NextDouble();
				values.Add(value);
			}

			return new Selection(values, range) { Name = "Нормальное" };
		}

		public static Selection GetNormalSelection(int selectionSize, int randomValuesAmount, double expectation, double deviation)
		{
			Random _random = new Random();
			List<double> values = new List<double>();

			double maxZ = (randomValuesAmount - randomValuesAmount / 2) / Math.Sqrt(randomValuesAmount / 12),
				   range = maxZ * deviation + expectation;

			for (int i = 0; i < selectionSize; i++)
			{
				double value = 0;
				for (int j = 0; j < randomValuesAmount; j++)
					value += _random.NextDouble();

				double z = (value - randomValuesAmount / 2) / Math.Sqrt(randomValuesAmount / 12),
					   x = z * deviation + expectation;

				values.Add(x);
			}

			return new Selection(values, range) { Name = "Нормальное с параметрами" };
		}

		public static Selection GetExponentialSelection(int selectionSize, double lambda)
		{
			Random _random = new Random();
			List<double> values = new List<double>();
			double range;

			for (int i = 0; i < selectionSize; i++)
				values.Add(-1f / lambda * Math.Log(_random.NextDouble()));

			range = values.Max() - values.Min();

			return new Selection(values, range) { Name = "Экспоненциальное" };
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
