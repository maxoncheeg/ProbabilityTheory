using ProbabilityTheory.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

			radioButtonUniformDistribution.CheckedChanged += RadioButtonUniformDistribution_CheckedChanged;
			radioButtonNormalDistribution.CheckedChanged += RadioButtonUniformDistribution_CheckedChanged;
			radioButtonExponentialDistribution.CheckedChanged += RadioButtonUniformDistribution_CheckedChanged;

			numericUpDownIntervalsAmount.ValueChanged += NumericUpDownIntervalsAmount_ValueChanged;
			numericUpDownLambda.ValueChanged += NumericUpDownLambda_ValueChanged;

			UpdateDistribution(null,null);
		}

		private void RadioButtonUniformDistribution_CheckedChanged(object sender, EventArgs e)
		{
			numericUpDownIntervalsAmount.Value++;
			numericUpDownIntervalsAmount.Value--;
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
				chartHistogram.Series[0] = _manager.GetUniformHistogram(_intervals);
			else if(radioButtonNormalDistribution.Checked)
				chartHistogram.Series[0] = _manager.GetNormalHistogram(_intervals);
			else if(radioButtonExponentialDistribution.Checked)
				chartHistogram.Series[0] = _manager.GetExponentialHistogram(_lambda, _intervals);
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
