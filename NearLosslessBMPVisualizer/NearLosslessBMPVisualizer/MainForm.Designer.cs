namespace NearLosslessBMPVisualizer
{
    partial class MainForm
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
            this.pictureBoxOriginalImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadBMP = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pictureBoxHistogram = new System.Windows.Forms.PictureBox();
            this.groupBoxHistogram = new System.Windows.Forms.GroupBox();
            this.numericUpDownHistogramScale = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxHistogram = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxOriginalImage = new System.Windows.Forms.GroupBox();
            this.groupBoxErrorValueMinMax = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxMaxErrorValue = new System.Windows.Forms.TextBox();
            this.textBoxMinErrorValue = new System.Windows.Forms.TextBox();
            this.numericUpDownKValue = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxSaveMode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxPredictorSelection = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSaveEncodedImage = new System.Windows.Forms.Button();
            this.btnEncodeOriginalImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogram)).BeginInit();
            this.groupBoxHistogram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHistogramScale)).BeginInit();
            this.groupBoxOriginalImage.SuspendLayout();
            this.groupBoxErrorValueMinMax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKValue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOriginalImage
            // 
            this.pictureBoxOriginalImage.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxOriginalImage.Location = new System.Drawing.Point(12, 29);
            this.pictureBoxOriginalImage.Name = "pictureBoxOriginalImage";
            this.pictureBoxOriginalImage.Size = new System.Drawing.Size(294, 289);
            this.pictureBoxOriginalImage.TabIndex = 0;
            this.pictureBoxOriginalImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original Image";
            // 
            // btnLoadBMP
            // 
            this.btnLoadBMP.Location = new System.Drawing.Point(25, 21);
            this.btnLoadBMP.Name = "btnLoadBMP";
            this.btnLoadBMP.Size = new System.Drawing.Size(75, 31);
            this.btnLoadBMP.TabIndex = 2;
            this.btnLoadBMP.Text = "Load";
            this.btnLoadBMP.UseVisualStyleBackColor = true;
            this.btnLoadBMP.Click += new System.EventHandler(this.btnLoadBMP_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(556, 26);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 27);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pictureBoxHistogram
            // 
            this.pictureBoxHistogram.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxHistogram.Location = new System.Drawing.Point(394, 391);
            this.pictureBoxHistogram.Name = "pictureBoxHistogram";
            this.pictureBoxHistogram.Size = new System.Drawing.Size(682, 279);
            this.pictureBoxHistogram.TabIndex = 6;
            this.pictureBoxHistogram.TabStop = false;
            // 
            // groupBoxHistogram
            // 
            this.groupBoxHistogram.Controls.Add(this.numericUpDownHistogramScale);
            this.groupBoxHistogram.Controls.Add(this.label3);
            this.groupBoxHistogram.Controls.Add(this.label2);
            this.groupBoxHistogram.Controls.Add(this.comboBoxHistogram);
            this.groupBoxHistogram.Controls.Add(this.btnRefresh);
            this.groupBoxHistogram.Location = new System.Drawing.Point(394, 324);
            this.groupBoxHistogram.Name = "groupBoxHistogram";
            this.groupBoxHistogram.Size = new System.Drawing.Size(682, 61);
            this.groupBoxHistogram.TabIndex = 7;
            this.groupBoxHistogram.TabStop = false;
            this.groupBoxHistogram.Text = "Histogram";
            // 
            // numericUpDownHistogramScale
            // 
            this.numericUpDownHistogramScale.DecimalPlaces = 1;
            this.numericUpDownHistogramScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownHistogramScale.Location = new System.Drawing.Point(421, 29);
            this.numericUpDownHistogramScale.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownHistogramScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownHistogramScale.Name = "numericUpDownHistogramScale";
            this.numericUpDownHistogramScale.Size = new System.Drawing.Size(67, 22);
            this.numericUpDownHistogramScale.TabIndex = 8;
            this.numericUpDownHistogramScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Scale :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select source image :";
            // 
            // comboBoxHistogram
            // 
            this.comboBoxHistogram.DisplayMember = "(none)";
            this.comboBoxHistogram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHistogram.FormattingEnabled = true;
            this.comboBoxHistogram.Items.AddRange(new object[] {
            "Original Image",
            "Prediction Error",
            "Prediction Error Q",
            "Decoded Image"});
            this.comboBoxHistogram.Location = new System.Drawing.Point(189, 28);
            this.comboBoxHistogram.Name = "comboBoxHistogram";
            this.comboBoxHistogram.Size = new System.Drawing.Size(164, 24);
            this.comboBoxHistogram.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 673);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "-255";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1044, 673);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "255";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(731, 673);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "0";
            // 
            // groupBoxOriginalImage
            // 
            this.groupBoxOriginalImage.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxOriginalImage.Controls.Add(this.groupBoxErrorValueMinMax);
            this.groupBoxOriginalImage.Controls.Add(this.numericUpDownKValue);
            this.groupBoxOriginalImage.Controls.Add(this.label9);
            this.groupBoxOriginalImage.Controls.Add(this.comboBoxSaveMode);
            this.groupBoxOriginalImage.Controls.Add(this.label8);
            this.groupBoxOriginalImage.Controls.Add(this.comboBoxPredictorSelection);
            this.groupBoxOriginalImage.Controls.Add(this.label7);
            this.groupBoxOriginalImage.Controls.Add(this.btnSaveEncodedImage);
            this.groupBoxOriginalImage.Controls.Add(this.btnEncodeOriginalImage);
            this.groupBoxOriginalImage.Controls.Add(this.btnLoadBMP);
            this.groupBoxOriginalImage.Location = new System.Drawing.Point(12, 324);
            this.groupBoxOriginalImage.Name = "groupBoxOriginalImage";
            this.groupBoxOriginalImage.Size = new System.Drawing.Size(294, 346);
            this.groupBoxOriginalImage.TabIndex = 12;
            this.groupBoxOriginalImage.TabStop = false;
            this.groupBoxOriginalImage.Text = "Operations";
            // 
            // groupBoxErrorValueMinMax
            // 
            this.groupBoxErrorValueMinMax.Controls.Add(this.label11);
            this.groupBoxErrorValueMinMax.Controls.Add(this.label10);
            this.groupBoxErrorValueMinMax.Controls.Add(this.textBoxMaxErrorValue);
            this.groupBoxErrorValueMinMax.Controls.Add(this.textBoxMinErrorValue);
            this.groupBoxErrorValueMinMax.Location = new System.Drawing.Point(19, 220);
            this.groupBoxErrorValueMinMax.Name = "groupBoxErrorValueMinMax";
            this.groupBoxErrorValueMinMax.Size = new System.Drawing.Size(257, 107);
            this.groupBoxErrorValueMinMax.TabIndex = 13;
            this.groupBoxErrorValueMinMax.TabStop = false;
            this.groupBoxErrorValueMinMax.Text = "Error (original - decoded)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Max value :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Min value :";
            // 
            // textBoxMaxErrorValue
            // 
            this.textBoxMaxErrorValue.Location = new System.Drawing.Point(137, 72);
            this.textBoxMaxErrorValue.Name = "textBoxMaxErrorValue";
            this.textBoxMaxErrorValue.ReadOnly = true;
            this.textBoxMaxErrorValue.Size = new System.Drawing.Size(100, 22);
            this.textBoxMaxErrorValue.TabIndex = 13;
            // 
            // textBoxMinErrorValue
            // 
            this.textBoxMinErrorValue.Location = new System.Drawing.Point(137, 31);
            this.textBoxMinErrorValue.Name = "textBoxMinErrorValue";
            this.textBoxMinErrorValue.ReadOnly = true;
            this.textBoxMinErrorValue.Size = new System.Drawing.Size(100, 22);
            this.textBoxMinErrorValue.TabIndex = 13;
            // 
            // numericUpDownKValue
            // 
            this.numericUpDownKValue.Location = new System.Drawing.Point(156, 145);
            this.numericUpDownKValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownKValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKValue.Name = "numericUpDownKValue";
            this.numericUpDownKValue.Size = new System.Drawing.Size(67, 22);
            this.numericUpDownKValue.TabIndex = 13;
            this.numericUpDownKValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "K value :";
            // 
            // comboBoxSaveMode
            // 
            this.comboBoxSaveMode.DisplayMember = "(none)";
            this.comboBoxSaveMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSaveMode.FormattingEnabled = true;
            this.comboBoxSaveMode.Items.AddRange(new object[] {
            "Fixed (32/16/9)",
            "Table",
            "Arithmetic"});
            this.comboBoxSaveMode.Location = new System.Drawing.Point(156, 109);
            this.comboBoxSaveMode.Name = "comboBoxSaveMode";
            this.comboBoxSaveMode.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSaveMode.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Save mode :";
            // 
            // comboBoxPredictorSelection
            // 
            this.comboBoxPredictorSelection.DisplayMember = "(none)";
            this.comboBoxPredictorSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPredictorSelection.FormattingEnabled = true;
            this.comboBoxPredictorSelection.Items.AddRange(new object[] {
            "128",
            "A",
            "B",
            "C",
            "A + B - C",
            "A + (B - C) / 2",
            "B + (A - C) / 2",
            "(A + B) / 2",
            "JpegLS"});
            this.comboBoxPredictorSelection.Location = new System.Drawing.Point(156, 73);
            this.comboBoxPredictorSelection.Name = "comboBoxPredictorSelection";
            this.comboBoxPredictorSelection.Size = new System.Drawing.Size(120, 24);
            this.comboBoxPredictorSelection.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Predictor Selection :";
            // 
            // btnSaveEncodedImage
            // 
            this.btnSaveEncodedImage.Location = new System.Drawing.Point(201, 21);
            this.btnSaveEncodedImage.Name = "btnSaveEncodedImage";
            this.btnSaveEncodedImage.Size = new System.Drawing.Size(75, 31);
            this.btnSaveEncodedImage.TabIndex = 13;
            this.btnSaveEncodedImage.Text = "Save";
            this.btnSaveEncodedImage.UseVisualStyleBackColor = true;
            // 
            // btnEncodeOriginalImage
            // 
            this.btnEncodeOriginalImage.Location = new System.Drawing.Point(115, 21);
            this.btnEncodeOriginalImage.Name = "btnEncodeOriginalImage";
            this.btnEncodeOriginalImage.Size = new System.Drawing.Size(75, 31);
            this.btnEncodeOriginalImage.TabIndex = 13;
            this.btnEncodeOriginalImage.Text = "Encode";
            this.btnEncodeOriginalImage.UseVisualStyleBackColor = true;
            this.btnEncodeOriginalImage.Click += new System.EventHandler(this.btnEncodeOriginalImage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1126, 704);
            this.Controls.Add(this.groupBoxOriginalImage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBoxHistogram);
            this.Controls.Add(this.pictureBoxHistogram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxOriginalImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Near-Lossless Grayscale BMP Visualizer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogram)).EndInit();
            this.groupBoxHistogram.ResumeLayout(false);
            this.groupBoxHistogram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHistogramScale)).EndInit();
            this.groupBoxOriginalImage.ResumeLayout(false);
            this.groupBoxOriginalImage.PerformLayout();
            this.groupBoxErrorValueMinMax.ResumeLayout(false);
            this.groupBoxErrorValueMinMax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginalImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadBMP;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox pictureBoxHistogram;
        private System.Windows.Forms.GroupBox groupBoxHistogram;
        private System.Windows.Forms.ComboBox comboBoxHistogram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownHistogramScale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxOriginalImage;
        private System.Windows.Forms.ComboBox comboBoxPredictorSelection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveEncodedImage;
        private System.Windows.Forms.Button btnEncodeOriginalImage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxSaveMode;
        private System.Windows.Forms.NumericUpDown numericUpDownKValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxErrorValueMinMax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxMaxErrorValue;
        private System.Windows.Forms.TextBox textBoxMinErrorValue;
    }
}

