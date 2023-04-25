namespace ProbabilityTheory.Forms
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chartHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButtonExponentialDistribution = new System.Windows.Forms.RadioButton();
			this.radioButtonNormalDistribution = new System.Windows.Forms.RadioButton();
			this.radioButtonUniformDistribution = new System.Windows.Forms.RadioButton();
			this.numericUpDownIntervalsAmount = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.labelLambda = new System.Windows.Forms.Label();
			this.numericUpDownLambda = new System.Windows.Forms.NumericUpDown();
			this.buttonUpdateSelection = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.numericUpDownSelectionSize = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.labelExpectation = new System.Windows.Forms.Label();
			this.labelVariance = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.labelMedian = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.labelMode = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalsAmount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLambda)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectionSize)).BeginInit();
			this.SuspendLayout();
			// 
			// chartHistogram
			// 
			this.chartHistogram.BorderSkin.BackColor = System.Drawing.Color.White;
			this.chartHistogram.BorderSkin.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			chartArea4.Name = "ChartArea1";
			this.chartHistogram.ChartAreas.Add(chartArea4);
			legend4.Name = "Legend1";
			this.chartHistogram.Legends.Add(legend4);
			this.chartHistogram.Location = new System.Drawing.Point(491, 44);
			this.chartHistogram.Name = "chartHistogram";
			this.chartHistogram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
			series4.ChartArea = "ChartArea1";
			series4.Legend = "Legend1";
			series4.Name = "Series1";
			this.chartHistogram.Series.Add(series4);
			this.chartHistogram.Size = new System.Drawing.Size(630, 526);
			this.chartHistogram.TabIndex = 0;
			this.chartHistogram.Text = "chart1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(486, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 27);
			this.label1.TabIndex = 1;
			this.label1.Text = "Гистограмма";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButtonExponentialDistribution);
			this.groupBox1.Controls.Add(this.radioButtonNormalDistribution);
			this.groupBox1.Controls.Add(this.radioButtonUniformDistribution);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(140)))), ((int)(((byte)(211)))));
			this.groupBox1.Location = new System.Drawing.Point(21, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(449, 156);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Распределение";
			// 
			// radioButtonExponentialDistribution
			// 
			this.radioButtonExponentialDistribution.AutoSize = true;
			this.radioButtonExponentialDistribution.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButtonExponentialDistribution.Location = new System.Drawing.Point(120, 108);
			this.radioButtonExponentialDistribution.Name = "radioButtonExponentialDistribution";
			this.radioButtonExponentialDistribution.Size = new System.Drawing.Size(234, 32);
			this.radioButtonExponentialDistribution.TabIndex = 2;
			this.radioButtonExponentialDistribution.Text = "Экспоненциальное";
			this.radioButtonExponentialDistribution.UseVisualStyleBackColor = true;
			// 
			// radioButtonNormalDistribution
			// 
			this.radioButtonNormalDistribution.AutoSize = true;
			this.radioButtonNormalDistribution.Checked = true;
			this.radioButtonNormalDistribution.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButtonNormalDistribution.Location = new System.Drawing.Point(120, 70);
			this.radioButtonNormalDistribution.Name = "radioButtonNormalDistribution";
			this.radioButtonNormalDistribution.Size = new System.Drawing.Size(162, 32);
			this.radioButtonNormalDistribution.TabIndex = 1;
			this.radioButtonNormalDistribution.TabStop = true;
			this.radioButtonNormalDistribution.Text = "Нормальное";
			this.radioButtonNormalDistribution.UseVisualStyleBackColor = true;
			// 
			// radioButtonUniformDistribution
			// 
			this.radioButtonUniformDistribution.AutoSize = true;
			this.radioButtonUniformDistribution.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButtonUniformDistribution.Location = new System.Drawing.Point(120, 32);
			this.radioButtonUniformDistribution.Name = "radioButtonUniformDistribution";
			this.radioButtonUniformDistribution.Size = new System.Drawing.Size(174, 32);
			this.radioButtonUniformDistribution.TabIndex = 0;
			this.radioButtonUniformDistribution.Text = "Равномерное";
			this.radioButtonUniformDistribution.UseVisualStyleBackColor = true;
			// 
			// numericUpDownIntervalsAmount
			// 
			this.numericUpDownIntervalsAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.numericUpDownIntervalsAmount.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numericUpDownIntervalsAmount.Location = new System.Drawing.Point(153, 251);
			this.numericUpDownIntervalsAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownIntervalsAmount.Name = "numericUpDownIntervalsAmount";
			this.numericUpDownIntervalsAmount.Size = new System.Drawing.Size(186, 38);
			this.numericUpDownIntervalsAmount.TabIndex = 3;
			this.numericUpDownIntervalsAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownIntervalsAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(16, 199);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(264, 27);
			this.label2.TabIndex = 4;
			this.label2.Text = "Количество интервалов";
			// 
			// labelLambda
			// 
			this.labelLambda.AutoSize = true;
			this.labelLambda.ForeColor = System.Drawing.Color.Black;
			this.labelLambda.Location = new System.Drawing.Point(16, 431);
			this.labelLambda.Name = "labelLambda";
			this.labelLambda.Size = new System.Drawing.Size(132, 27);
			this.labelLambda.TabIndex = 6;
			this.labelLambda.Text = "Значение λ";
			// 
			// numericUpDownLambda
			// 
			this.numericUpDownLambda.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.numericUpDownLambda.DecimalPlaces = 1;
			this.numericUpDownLambda.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numericUpDownLambda.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDownLambda.Location = new System.Drawing.Point(153, 483);
			this.numericUpDownLambda.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericUpDownLambda.Name = "numericUpDownLambda";
			this.numericUpDownLambda.Size = new System.Drawing.Size(186, 38);
			this.numericUpDownLambda.TabIndex = 5;
			this.numericUpDownLambda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownLambda.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			// 
			// buttonUpdateSelection
			// 
			this.buttonUpdateSelection.BackColor = System.Drawing.Color.White;
			this.buttonUpdateSelection.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.buttonUpdateSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUpdateSelection.Location = new System.Drawing.Point(54, 595);
			this.buttonUpdateSelection.Name = "buttonUpdateSelection";
			this.buttonUpdateSelection.Size = new System.Drawing.Size(373, 108);
			this.buttonUpdateSelection.TabIndex = 7;
			this.buttonUpdateSelection.Text = "Новая выборка";
			this.buttonUpdateSelection.UseVisualStyleBackColor = false;
			this.buttonUpdateSelection.Click += new System.EventHandler(this.buttonUpdateSelection_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(16, 312);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(180, 27);
			this.label4.TabIndex = 9;
			this.label4.Text = "Размер выборки";
			// 
			// numericUpDownSelectionSize
			// 
			this.numericUpDownSelectionSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.numericUpDownSelectionSize.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numericUpDownSelectionSize.Location = new System.Drawing.Point(153, 364);
			this.numericUpDownSelectionSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDownSelectionSize.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericUpDownSelectionSize.Name = "numericUpDownSelectionSize";
			this.numericUpDownSelectionSize.Size = new System.Drawing.Size(186, 38);
			this.numericUpDownSelectionSize.TabIndex = 8;
			this.numericUpDownSelectionSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownSelectionSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(486, 595);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(288, 27);
			this.label5.TabIndex = 10;
			this.label5.Text = "Математическое ожидание";
			// 
			// labelExpectation
			// 
			this.labelExpectation.ForeColor = System.Drawing.Color.Black;
			this.labelExpectation.Location = new System.Drawing.Point(833, 595);
			this.labelExpectation.Name = "labelExpectation";
			this.labelExpectation.Size = new System.Drawing.Size(288, 27);
			this.labelExpectation.TabIndex = 11;
			this.labelExpectation.Text = "0.000";
			this.labelExpectation.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// labelVariance
			// 
			this.labelVariance.ForeColor = System.Drawing.Color.Black;
			this.labelVariance.Location = new System.Drawing.Point(833, 622);
			this.labelVariance.Name = "labelVariance";
			this.labelVariance.Size = new System.Drawing.Size(288, 27);
			this.labelVariance.TabIndex = 13;
			this.labelVariance.Text = "0.000";
			this.labelVariance.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(486, 622);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(120, 27);
			this.label8.TabIndex = 12;
			this.label8.Text = "Дисперсия";
			// 
			// labelMedian
			// 
			this.labelMedian.ForeColor = System.Drawing.Color.Black;
			this.labelMedian.Location = new System.Drawing.Point(833, 649);
			this.labelMedian.Name = "labelMedian";
			this.labelMedian.Size = new System.Drawing.Size(288, 27);
			this.labelMedian.TabIndex = 15;
			this.labelMedian.Text = "0.000";
			this.labelMedian.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(486, 649);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 27);
			this.label7.TabIndex = 14;
			this.label7.Text = "Медиана";
			// 
			// labelMode
			// 
			this.labelMode.ForeColor = System.Drawing.Color.Black;
			this.labelMode.Location = new System.Drawing.Point(833, 676);
			this.labelMode.Name = "labelMode";
			this.labelMode.Size = new System.Drawing.Size(288, 27);
			this.labelMode.TabIndex = 17;
			this.labelMode.Text = "0.000";
			this.labelMode.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(486, 676);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(60, 27);
			this.label10.TabIndex = 16;
			this.label10.Text = "Мода";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(1136, 727);
			this.Controls.Add(this.labelMode);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.labelMedian);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.labelVariance);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.labelExpectation);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.numericUpDownSelectionSize);
			this.Controls.Add(this.buttonUpdateSelection);
			this.Controls.Add(this.labelLambda);
			this.Controls.Add(this.numericUpDownLambda);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numericUpDownIntervalsAmount);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.chartHistogram);
			this.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormMain";
			this.Text = "Теория Вероятностей";
			this.Load += new System.EventHandler(this.FormMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalsAmount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLambda)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectionSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chartHistogram;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButtonExponentialDistribution;
		private System.Windows.Forms.RadioButton radioButtonNormalDistribution;
		private System.Windows.Forms.RadioButton radioButtonUniformDistribution;
		private System.Windows.Forms.NumericUpDown numericUpDownIntervalsAmount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelLambda;
		private System.Windows.Forms.NumericUpDown numericUpDownLambda;
		private System.Windows.Forms.Button buttonUpdateSelection;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numericUpDownSelectionSize;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelExpectation;
		private System.Windows.Forms.Label labelVariance;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label labelMedian;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label labelMode;
		private System.Windows.Forms.Label label10;
	}
}