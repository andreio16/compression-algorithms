namespace WaveletDecompositionVisualizer
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
            this.pictureBoxWaveletImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxWaveletImage = new System.Windows.Forms.GroupBox();
            this.btnSyV1 = new System.Windows.Forms.Button();
            this.btnSyH1 = new System.Windows.Forms.Button();
            this.btnAnV1 = new System.Windows.Forms.Button();
            this.btnAnH1 = new System.Windows.Forms.Button();
            this.groupBoxWaveletSettup = new System.Windows.Forms.GroupBox();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownOffset = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownScale = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnShowWavelet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaveletImage)).BeginInit();
            this.groupBoxWaveletImage.SuspendLayout();
            this.groupBoxWaveletSettup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOriginalImage
            // 
            this.pictureBoxOriginalImage.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxOriginalImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginalImage.Location = new System.Drawing.Point(21, 30);
            this.pictureBoxOriginalImage.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxOriginalImage.Name = "pictureBoxOriginalImage";
            this.pictureBoxOriginalImage.Size = new System.Drawing.Size(512, 512);
            this.pictureBoxOriginalImage.TabIndex = 1;
            this.pictureBoxOriginalImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original Image";
            // 
            // btnLoadBMP
            // 
            this.btnLoadBMP.Location = new System.Drawing.Point(21, 546);
            this.btnLoadBMP.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadBMP.Name = "btnLoadBMP";
            this.btnLoadBMP.Size = new System.Drawing.Size(78, 25);
            this.btnLoadBMP.TabIndex = 3;
            this.btnLoadBMP.Text = "Load BMP";
            this.btnLoadBMP.UseVisualStyleBackColor = true;
            this.btnLoadBMP.Click += new System.EventHandler(this.btnLoadBMP_Click);
            // 
            // pictureBoxWaveletImage
            // 
            this.pictureBoxWaveletImage.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxWaveletImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWaveletImage.Location = new System.Drawing.Point(552, 30);
            this.pictureBoxWaveletImage.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxWaveletImage.Name = "pictureBoxWaveletImage";
            this.pictureBoxWaveletImage.Size = new System.Drawing.Size(512, 512);
            this.pictureBoxWaveletImage.TabIndex = 4;
            this.pictureBoxWaveletImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(778, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wavelet Image";
            // 
            // groupBoxWaveletImage
            // 
            this.groupBoxWaveletImage.Controls.Add(this.btnShowWavelet);
            this.groupBoxWaveletImage.Controls.Add(this.btnRefresh);
            this.groupBoxWaveletImage.Controls.Add(this.btnSyV1);
            this.groupBoxWaveletImage.Controls.Add(this.btnSyH1);
            this.groupBoxWaveletImage.Controls.Add(this.btnAnV1);
            this.groupBoxWaveletImage.Controls.Add(this.btnAnH1);
            this.groupBoxWaveletImage.Location = new System.Drawing.Point(1076, 133);
            this.groupBoxWaveletImage.Name = "groupBoxWaveletImage";
            this.groupBoxWaveletImage.Size = new System.Drawing.Size(223, 409);
            this.groupBoxWaveletImage.TabIndex = 6;
            this.groupBoxWaveletImage.TabStop = false;
            this.groupBoxWaveletImage.Text = "Wavelet Operations";
            // 
            // btnSyV1
            // 
            this.btnSyV1.Location = new System.Drawing.Point(126, 70);
            this.btnSyV1.Margin = new System.Windows.Forms.Padding(2);
            this.btnSyV1.Name = "btnSyV1";
            this.btnSyV1.Size = new System.Drawing.Size(77, 25);
            this.btnSyV1.TabIndex = 7;
            this.btnSyV1.Text = "Sy V1";
            this.btnSyV1.UseVisualStyleBackColor = true;
            // 
            // btnSyH1
            // 
            this.btnSyH1.Location = new System.Drawing.Point(126, 32);
            this.btnSyH1.Margin = new System.Windows.Forms.Padding(2);
            this.btnSyH1.Name = "btnSyH1";
            this.btnSyH1.Size = new System.Drawing.Size(77, 25);
            this.btnSyH1.TabIndex = 6;
            this.btnSyH1.Text = "Sy H1";
            this.btnSyH1.UseVisualStyleBackColor = true;
            this.btnSyH1.Click += new System.EventHandler(this.btnSyH1_Click);
            // 
            // btnAnV1
            // 
            this.btnAnV1.Location = new System.Drawing.Point(24, 70);
            this.btnAnV1.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnV1.Name = "btnAnV1";
            this.btnAnV1.Size = new System.Drawing.Size(77, 25);
            this.btnAnV1.TabIndex = 5;
            this.btnAnV1.Text = "An V1";
            this.btnAnV1.UseVisualStyleBackColor = true;
            // 
            // btnAnH1
            // 
            this.btnAnH1.Location = new System.Drawing.Point(24, 32);
            this.btnAnH1.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnH1.Name = "btnAnH1";
            this.btnAnH1.Size = new System.Drawing.Size(77, 25);
            this.btnAnH1.TabIndex = 4;
            this.btnAnH1.Text = "An H1";
            this.btnAnH1.UseVisualStyleBackColor = true;
            this.btnAnH1.Click += new System.EventHandler(this.btnAnH1_Click);
            // 
            // groupBoxWaveletSettup
            // 
            this.groupBoxWaveletSettup.Controls.Add(this.numericUpDownY);
            this.groupBoxWaveletSettup.Controls.Add(this.label6);
            this.groupBoxWaveletSettup.Controls.Add(this.numericUpDownX);
            this.groupBoxWaveletSettup.Controls.Add(this.label5);
            this.groupBoxWaveletSettup.Controls.Add(this.numericUpDownOffset);
            this.groupBoxWaveletSettup.Controls.Add(this.label4);
            this.groupBoxWaveletSettup.Controls.Add(this.numericUpDownScale);
            this.groupBoxWaveletSettup.Controls.Add(this.label3);
            this.groupBoxWaveletSettup.Location = new System.Drawing.Point(1076, 30);
            this.groupBoxWaveletSettup.Name = "groupBoxWaveletSettup";
            this.groupBoxWaveletSettup.Size = new System.Drawing.Size(223, 97);
            this.groupBoxWaveletSettup.TabIndex = 7;
            this.groupBoxWaveletSettup.TabStop = false;
            this.groupBoxWaveletSettup.Text = "Settings";
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(149, 60);
            this.numericUpDownY.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownY.TabIndex = 16;
            this.numericUpDownY.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Y :";
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(149, 30);
            this.numericUpDownX.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownX.TabIndex = 14;
            this.numericUpDownX.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "X :";
            // 
            // numericUpDownOffset
            // 
            this.numericUpDownOffset.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownOffset.Location = new System.Drawing.Point(51, 59);
            this.numericUpDownOffset.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownOffset.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericUpDownOffset.Name = "numericUpDownOffset";
            this.numericUpDownOffset.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownOffset.TabIndex = 12;
            this.numericUpDownOffset.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Offset :";
            // 
            // numericUpDownScale
            // 
            this.numericUpDownScale.DecimalPlaces = 2;
            this.numericUpDownScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownScale.Location = new System.Drawing.Point(51, 29);
            this.numericUpDownScale.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownScale.Name = "numericUpDownScale";
            this.numericUpDownScale.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownScale.TabIndex = 10;
            this.numericUpDownScale.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Scale :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(24, 142);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 25);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnShowWavelet
            // 
            this.btnShowWavelet.Location = new System.Drawing.Point(128, 142);
            this.btnShowWavelet.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowWavelet.Name = "btnShowWavelet";
            this.btnShowWavelet.Size = new System.Drawing.Size(77, 25);
            this.btnShowWavelet.TabIndex = 9;
            this.btnShowWavelet.Text = "Show XY";
            this.btnShowWavelet.UseVisualStyleBackColor = true;
            this.btnShowWavelet.Click += new System.EventHandler(this.btnShowWavelet_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1311, 586);
            this.Controls.Add(this.groupBoxWaveletSettup);
            this.Controls.Add(this.groupBoxWaveletImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxWaveletImage);
            this.Controls.Add(this.btnLoadBMP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxOriginalImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Wavelet Decomposition BMP Visualizer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaveletImage)).EndInit();
            this.groupBoxWaveletImage.ResumeLayout(false);
            this.groupBoxWaveletSettup.ResumeLayout(false);
            this.groupBoxWaveletSettup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginalImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadBMP;
        private System.Windows.Forms.PictureBox pictureBoxWaveletImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxWaveletImage;
        private System.Windows.Forms.Button btnSyV1;
        private System.Windows.Forms.Button btnSyH1;
        private System.Windows.Forms.Button btnAnV1;
        private System.Windows.Forms.Button btnAnH1;
        private System.Windows.Forms.GroupBox groupBoxWaveletSettup;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownOffset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownScale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnShowWavelet;
    }
}

