using System;
using System.Collections.Generic;

namespace ProbabilityTheory.Classes
{
	internal class ExponentialSelection : Selection
	{
		public double Lambda { get; private set; }

		protected ExponentialSelection(List<double> Values, double Lambda) : base(Values)
		{
			this.Lambda = Lambda;
		}

		public static ExponentialSelection GetExponentialSelection(int selectionSize, double lambda)
		{
			Random _random = new Random();
			List<double> values = new List<double>();

			for (int i = 0; i < selectionSize; i++)
				values.Add(-1f / lambda * Math.Log(_random.NextDouble()));

			return new ExponentialSelection(values, lambda) { Name = "Экспоненциальное" };
		}

		////public static ExponentialSelection 
	}
}
