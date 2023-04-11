using ProbabilityTheory.Classes;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
			numericUpDownLambda.ValueChanged += NumericUpDownLambda_ValueChanged;

			UpdateDistribution(null,null);
		}

		private void RadioButtonExponentialDistribution_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonExponentialDistribution.Checked)
			{
				_manager.GetExponentialHistogram(chartHistogram.Series[0], _lambda, _intervals);
			}
		}

		private void RadioButtonNormalDistribution_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonNormalDistribution.Checked)
			{ 
				_manager.GetNormalHistogram(chartHistogram.Series[0], _intervals);
			}
		}

		private void RadioButtonUniformDistribution_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonUniformDistribution.Checked)
			{
				_manager.GetUniformHistogram(chartHistogram.Series[0], _intervals);
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
			if (radioButtonUniformDistribution.Checked)
				_manager.GetUniformHistogram(chartHistogram.Series[0], _intervals);
			else if(radioButtonNormalDistribution.Checked)
				_manager.GetNormalHistogram(chartHistogram.Series[0], _intervals);
			else if(radioButtonExponentialDistribution.Checked)
				_manager.GetExponentialHistogram(chartHistogram.Series[0], _lambda, _intervals);
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			FormPlacer.ToScreenCenter(this);
		}

		private void buttonUpdateSelection_Click(object sender, EventArgs e)
		{
			_manager.UpdateSelection();
			UpdateDistribution(null, null);
		}
	}
}
