using ProbabilityTheory.Classes;
using System;
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


			buttonUpdateSelection.Click += OnPropertiesChange;

			OnIntervalsAmountChanged(this, null);
		}

		private void OnAlphaChanged(object sender, EventArgs e)
		{
			_hypothesis = Hypothesis.KolmogorovHypothesis(_selection, (double)numericUpDownAlpha.Value);
			labelLambdaDistribution.Text = _hypothesis.DistributionFunctionValue.ToString();
			labelLambdaTheory.Text = _hypothesis.TheoryFunctionValue.ToString();
			labelCorrect.Text = _hypothesis.IsCorrect ? "Верна" : "Неверна";


			//double s1 = 0, s2 = 0;
			//for (int i = 0; i < 10000; i++)
			//{
			//	_selection = ExponentialSelection.GetExponentialSelection(10, 0.7);
			//	s1 += Hypothesis.KolmogorovHypothesis(_selection, (double)numericUpDownAlpha.Value).DistributionFunctionValue;

			//	_selection = ExponentialSelection.GetExponentialSelection(10000, 0.7);
			//	s2 += Hypothesis.KolmogorovHypothesis(_selection, (double)numericUpDownAlpha.Value).DistributionFunctionValue;
			//}

			//MessageBox.Show("Выборка из 10 чисел.\n10000 попыток.\nсреднее F(lambda)=" + s1 / 10000);
			//MessageBox.Show("Выборка из 10000 чисел.\n10000 попыток.\nсреднее F(lambda)=" + s2 / 10000);
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

		private void FormExponential_Load(object sender, EventArgs e)
		{
			FormPlacer.ToScreenCenter(this);
		}
	}
}
