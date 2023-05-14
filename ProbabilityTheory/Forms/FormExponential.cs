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

			numericUpDownIntervalsAmount.ValueChanged += OnIntervalsAmountChanged; 
			numericUpDownLambda.ValueChanged += OnPropertiesChange;
			numericUpDownSelectionSize.ValueChanged += OnPropertiesChange;

			buttonUpdateSelection.Click += OnPropertiesChange;

			OnIntervalsAmountChanged(this, null);
		}

		private void OnIntervalsAmountChanged(object sender, EventArgs e)
		{
			_builder.BuildHistogram(_selection, (int)numericUpDownIntervalsAmount.Value);

			labelExpectation.Text = _selection.Expectation.ToString();
			labelVariance.Text = _selection.Variance.ToString();
			labelMedian.Text = _selection.Median.ToString();
			labelMode.Text = _builder.GetCurrentMode().ToString();

			_hypothesis = Hypothesis.KolmogorovHypothesis(_selection, (int)numericUpDownIntervalsAmount.Value);
			labelLambdaDistribution.Text = _hypothesis.DistributionLambda.ToString();
			labelLambdaTheory.Text = _hypothesis.TheoryLambda.ToString();
			labelX.Text = _hypothesis.XValue.ToString();
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
