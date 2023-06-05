using ProbabilityTheory.Classes;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbabilityTheory.Forms
{
	public partial class FormExponential : Form
	{
		private ExponentialSelection _selection;
		private DistributionHistogramBuilder _builder;
		private Hypothesis _hypothesis;

		public FormExponential()
		{
			InitializeComponent();

			_selection = ExponentialSelection.GetExponentialSelection((int)numericUpDownSelectionSize.Value, (double)numericUpDownLambda.Value);
			_builder = DistributionHistogramBuilder.Create(chartHistogram.Series[0]);

			numericUpDownAlpha.ValueChanged += OnAlphaChanged;
			numericUpDownIntervalsAmount.ValueChanged += OnIntervalsAmountChanged; 
			numericUpDownLambda.ValueChanged += OnPropertiesChange;
			numericUpDownSelectionSize.ValueChanged += OnPropertiesChange;

			label3.Click += Label3_Click;

			buttonUpdateSelection.Click += OnPropertiesChange;

			OnIntervalsAmountChanged(this, null);
		}

		private async void Label3_Click(object sender, EventArgs e)
		{
			string x = await GetFunctionAverageAsync();
			MessageBox.Show(x, "Пасхалка: среднее значение", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void OnAlphaChanged(object sender, EventArgs e)
		{
			_hypothesis = Hypothesis.KolmogorovHypothesis(_selection, (double)numericUpDownAlpha.Value);
			labelLambdaDistribution.Text = _hypothesis.DistributionFunctionValue.ToString();
			labelLambdaTheory.Text = _hypothesis.TheoryFunctionValue.ToString();
			labelCorrect.Text = _hypothesis.IsCorrect ? "Верна" : "Неверна";
		}

		private void OnIntervalsAmountChanged(object sender, EventArgs e)
		{
			_builder.BuildHistogram(_selection, (int)numericUpDownIntervalsAmount.Value);

			labelExpectation.Text = _selection.Expectation.ToString();
			labelVariance.Text = _selection.Variance.ToString();
			labelMedian.Text = _selection.Median.ToString();
			labelMode.Text = _builder.GetCurrentMode().ToString();

			OnAlphaChanged(this, null);
		}

		private void OnPropertiesChange(object sender, EventArgs e)
		{
			_selection = ExponentialSelection.GetExponentialSelection((int)numericUpDownSelectionSize.Value, (double)numericUpDownLambda.Value);
			OnIntervalsAmountChanged(this, null);
		}

		private async Task<string> GetFunctionAverageAsync()
		{
			string result = "";

			await Task.Run(() =>
			{
				ExponentialSelection selection;
				double sum1 = 0, sum2 = 0, alpha = (double)numericUpDownAlpha.Value;
				double lambda = (double)numericUpDownLambda.Value;
				for (int i = 0; i < 10000; i++)
				{
					selection = ExponentialSelection.GetExponentialSelection(10, lambda);
					sum1 += Hypothesis.KolmogorovHypothesis(selection, alpha).DistributionFunctionValue;

					selection = ExponentialSelection.GetExponentialSelection(10000, lambda);
					sum2 += Hypothesis.KolmogorovHypothesis(selection, alpha).DistributionFunctionValue;
				}

				result = $"Выборка из 10 чисел, среднее F(λраспр): {sum1 / 10000}" +
				$"\nВыборка из 10000 чисел, среднее F(λраспр): {sum2 / 10000}";
			});

			return result;
		}

		private void FormExponential_Load(object sender, EventArgs e)
		{
			FormPlacer.ToScreenCenter(this);
		}
	}
}
