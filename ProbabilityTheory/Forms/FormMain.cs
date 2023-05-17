using ProbabilityTheory.Classes;
using System;
using System.IO;
using System.Windows.Forms;

namespace ProbabilityTheory.Forms
{
	public partial class FormMain : Form
	{
		private int _intervals = 5;

		private Selection _uniformSelection;
		private Selection _normalSelection;

		private DistributionHistogramBuilder _builder;

		public FormMain()
		{
			InitializeComponent();

			_builder = DistributionHistogramBuilder.Create(chartHistogram.Series[0]);

			_uniformSelection = Selection.GetUniformSelection((int)numericUpDownSelectionSize.Value);
			_normalSelection = Selection.GetNormalSelection((int)numericUpDownSelectionSize.Value, 20);

			radioButtonUniformDistribution.CheckedChanged += OnRadioButtonCheckedChanged;
			radioButtonNormalDistribution.CheckedChanged += OnRadioButtonCheckedChanged;

			numericUpDownIntervalsAmount.ValueChanged += OnIntervalsAmountValueChanged;
			numericUpDownSelectionSize.ValueChanged += UpdateSelection;

			buttonUpdateSelection.Click += UpdateSelection;

			UpdateDistribution();
		}

		private void FormMain_Load(object sender, EventArgs e) =>
			FormPlacer.ToScreenCenter(this);

		private void UpdateSelection(object sender, EventArgs e)
		{
			_uniformSelection = Selection.GetUniformSelection((int)numericUpDownSelectionSize.Value);
			_normalSelection = Selection.GetNormalSelection((int)numericUpDownSelectionSize.Value, 20);

			UpdateDistribution();
		}

		private void OnRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			if ((sender as RadioButton).Checked) UpdateDistribution();
		}

		private void OnIntervalsAmountValueChanged(object sender, EventArgs e)
		{
			_intervals = (int)numericUpDownIntervalsAmount.Value;
			UpdateDistribution();
		}

		private void UpdateDistribution()
		{
			Selection currentSelection = null;

			if (radioButtonUniformDistribution.Checked)
				currentSelection = _uniformSelection;
			else if (radioButtonNormalDistribution.Checked)
				currentSelection = _normalSelection;

			_builder.BuildHistogram(currentSelection, _intervals);

			labelExpectation.Text = Math.Round(currentSelection.Expectation, 4).ToString();
			labelVariance.Text = Math.Round(currentSelection.Variance, 4).ToString();
			labelMedian.Text = Math.Round(currentSelection.Median, 4).ToString();
			labelMode.Text = Math.Round(_builder.GetCurrentMode(), 4).ToString();
		}

		private void buttonIntervals_Click(object sender, EventArgs e)
		{
			FormIntervals form = new FormIntervals();
			form.ShowDialog();
		}

		private void buttonExponential_Click(object sender, EventArgs e)
		{
			FormExponential form = new FormExponential();
			form.ShowDialog();
		}
	}
}
