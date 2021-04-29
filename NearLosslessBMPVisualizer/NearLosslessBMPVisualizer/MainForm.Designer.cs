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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxHistogram = new System.Windows.Forms.ComboBox();
            this.numericUpDownHistogramScale = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogram)).BeginInit();
            this.groupBoxHistogram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHistogramScale)).BeginInit();
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
            this.btnLoadBMP.Location = new System.Drawing.Point(12, 324);
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
            // 
            // pictureBoxHistogram
            // 
            this.pictureBoxHistogram.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxHistogram.Location = new System.Drawing.Point(460, 420);
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
            this.groupBoxHistogram.Location = new System.Drawing.Point(460, 353);
            this.groupBoxHistogram.Name = "groupBoxHistogram";
            this.groupBoxHistogram.Size = new System.Drawing.Size(682, 61);
            this.groupBoxHistogram.TabIndex = 7;
            this.groupBoxHistogram.TabStop = false;
            this.groupBoxHistogram.Text = "Histogram";
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
            this.comboBoxHistogram.Size = new System.Drawing.Size(121, 24);
            this.comboBoxHistogram.TabIndex = 8;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 702);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "-255";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1110, 702);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "255";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(797, 702);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1165, 727);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBoxHistogram);
            this.Controls.Add(this.pictureBoxHistogram);
            this.Controls.Add(this.btnLoadBMP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxOriginalImage);
            this.Name = "MainForm";
            this.Text = "Near-Lossless Grayscale BMP Visualizer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogram)).EndInit();
            this.groupBoxHistogram.ResumeLayout(false);
            this.groupBoxHistogram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHistogramScale)).EndInit();
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
    }
}

