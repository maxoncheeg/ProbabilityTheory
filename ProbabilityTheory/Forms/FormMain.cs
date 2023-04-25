using ProbabilityTheory.Classes;
using System;
using System.Windows.Forms;

namespace ProbabilityTheory.Forms
{
	public partial class FormMain : Form
	{
		private int _intervals = 5;
		private double _lambda = 0.1f;
		private DistributionManager _manager;

		public FormMain()
		{
			InitializeComponent();

			_manager = DistributionManager.Create();

			radioButtonUniformDistribution.CheckedChanged += RadioButtonUniformDistribution_CheckedChanged; ;
			radioButtonNormalDistribution.CheckedChanged += RadioButtonNormalDistribution_CheckedChanged; ;
			radioButtonExponentialDistribution.CheckedChanged += RadioButtonExponentialDistribution_CheckedChanged; ;

			numericUpDownIntervalsAmount.ValueChanged += NumericUpDownIntervalsAmount_ValueChanged;
			numericUpDownSelectionSize.ValueChanged += buttonUpdateSelection_Click;
			numericUpDownLambda.ValueChanged += NumericUpDownLambda_ValueChanged;

			buttonUpdateSelection_Click(null,null);
		}

		private void RadioButtonExponentialDistribution_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonExponentialDistribution.Checked)
			{
				UpdateDistribution(null, null);
			}
		}

		private void RadioButtonNormalDistribution_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonNormalDistribution.Checked)
			{
				UpdateDistribution(null, null);
			}
		}

		private void RadioButtonUniformDistribution_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonUniformDistribution.Checked)
			{
				UpdateDistribution(null, null);
			}
		}

		private void NumericUpDownLambda_ValueChanged(object sender, EventArgs e)
		{
			_lambda = (double)numericUpDownLambda.Value;
			UpdateDistribution(null, null);
		}

		private void NumericUpDownIntervalsAmount_ValueChanged(object sender, EventArgs e)
		{
			_intervals = (int)numericUpDownIntervalsAmount.Value;
			UpdateDistribution(null, null);
		}

		private void UpdateDistribution(object sender, EventArgs e)
		{
			labelLambda.Enabled = numericUpDownLambda.Enabled = radioButtonExponentialDistribution.Checked;

			if (radioButtonUniformDistribution.Checked)
				_manager.GetUniformHistogram(chartHistogram.Series[0], _intervals);
			else if(radioButtonNormalDistribution.Checked)
				_manager.GetNormalHistogram(chartHistogram.Series[0], _intervals);
			else if(radioButtonExponentialDistribution.Checked)
				_manager.GetExponentialHistogram(chartHistogram.Series[0], _lambda, _intervals);

			labelExpectation.Text = Math.Round(_manager.Expectation, 4).ToString();
			labelVariance.Text = Math.Round(_manager.Variance, 4).ToString();
			labelMedian.Text = Math.Round(_manager.Median, 4).ToString();
			labelMode.Text = Math.Round(_manager.Mode, 4).ToString();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			FormPlacer.ToScreenCenter(this);
		}

		private void buttonUpdateSelection_Click(object sender, EventArgs e)
		{
			_manager.UpdateSelection((int)numericUpDownSelectionSize.Value);
			UpdateDistribution(null, null);
		}
	}
}
