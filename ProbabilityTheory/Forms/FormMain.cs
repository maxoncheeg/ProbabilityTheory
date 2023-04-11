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

			radioButtonUniformDistribution.CheckedChanged += UpdateDistribution;
			radioButtonNormalDistribution.CheckedChanged += UpdateDistribution;
			radioButtonExponentialDistribution.CheckedChanged += UpdateDistribution;

			numericUpDownIntervalsAmount.ValueChanged += NumericUpDownIntervalsAmount_ValueChanged;
			numericUpDownLambda.ValueChanged += NumericUpDownLambda_ValueChanged;

			UpdateDistribution(null,null);
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
