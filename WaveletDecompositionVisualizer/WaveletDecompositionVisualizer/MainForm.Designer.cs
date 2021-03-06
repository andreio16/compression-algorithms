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
            this.btnSyV5 = new System.Windows.Forms.Button();
            this.btnSyH5 = new System.Windows.Forms.Button();
            this.btnAnV5 = new System.Windows.Forms.Button();
            this.btnAnH5 = new System.Windows.Forms.Button();
            this.btnSyV4 = new System.Windows.Forms.Button();
            this.btnSyH4 = new System.Windows.Forms.Button();
            this.btnAnV4 = new System.Windows.Forms.Button();
            this.btnAnH4 = new System.Windows.Forms.Button();
            this.btnSyV3 = new System.Windows.Forms.Button();
            this.btnSyH3 = new System.Windows.Forms.Button();
            this.btnAnV3 = new System.Windows.Forms.Button();
            this.btnAnH3 = new System.Windows.Forms.Button();
            this.btnSyv2 = new System.Windows.Forms.Button();
            this.btnSyH2 = new System.Windows.Forms.Button();
            this.btnAnV2 = new System.Windows.Forms.Button();
            this.btnAnH2 = new System.Windows.Forms.Button();
            this.btnShowWavelet = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
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
            this.btnSaveEncodedWVL = new System.Windows.Forms.Button();
            this.btnLoadWVL = new System.Windows.Forms.Button();
            this.groupBoxErrorValueMinMax = new System.Windows.Forms.GroupBox();
            this.btnVerifyError = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxMaxErrorValue = new System.Windows.Forms.TextBox();
            this.textBoxMinErrorValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaveletImage)).BeginInit();
            this.groupBoxWaveletImage.SuspendLayout();
            this.groupBoxWaveletSettup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).BeginInit();
            this.groupBoxErrorValueMinMax.SuspendLayout();
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
            this.groupBoxWaveletImage.Controls.Add(this.btnSyV5);
            this.groupBoxWaveletImage.Controls.Add(this.btnSyH5);
            this.groupBoxWaveletImage.Controls.Add(this.btnAnV5);
            this.groupBoxWaveletImage.Controls.Add(this.btnAnH5);
            this.groupBoxWaveletImage.Controls.Add(this.btnSyV4);
            this.groupBoxWaveletImage.Controls.Add(this.btnSyH4);
            this.groupBoxWaveletImage.Controls.Add(this.btnAnV4);
            this.groupBoxWaveletImage.Controls.Add(this.btnAnH4);
            this.groupBoxWaveletImage.Controls.Add(this.btnSyV3);
            this.groupBoxWaveletImage.Controls.Add(this.btnSyH3);
            this.groupBoxWaveletImage.Controls.Add(this.btnAnV3);
            this.groupBoxWaveletImage.Controls.Add(this.btnAnH3);
            this.groupBoxWaveletImage.Controls.Add(this.btnSyv2);
            this.groupBoxWaveletImage.Controls.Add(this.btnSyH2);
            this.groupBoxWaveletImage.Controls.Add(this.btnAnV2);
            this.groupBoxWaveletImage.Controls.Add(this.btnAnH2);
            this.groupBoxWaveletImage.Controls.Add(this.btnShowWavelet);
            this.groupBoxWaveletImage.Controls.Add(this.btnRefresh);
            this.groupBoxWaveletImage.Controls.Add(this.btnSyV1);
            this.groupBoxWaveletImage.Controls.Add(this.btnSyH1);
            this.groupBoxWaveletImage.Controls.Add(this.btnAnV1);
            this.groupBoxWaveletImage.Controls.Add(this.btnAnH1);
            this.groupBoxWaveletImage.Location = new System.Drawing.Point(1076, 133);
            this.groupBoxWaveletImage.Name = "groupBoxWaveletImage";
            this.groupBoxWaveletImage.Size = new System.Drawing.Size(223, 309);
            this.groupBoxWaveletImage.TabIndex = 6;
            this.groupBoxWaveletImage.TabStop = false;
            this.groupBoxWaveletImage.Text = "Wavelet Operations";
            // 
            // btnSyV5
            // 
            this.btnSyV5.Location = new System.Drawing.Point(169, 137);
            this.btnSyV5.Margin = new System.Windows.Forms.Padding(2);
            this.btnSyV5.Name = "btnSyV5";
            this.btnSyV5.Size = new System.Drawing.Size(45, 25);
            this.btnSyV5.TabIndex = 25;
            this.btnSyV5.Text = "Sy V5";
            this.btnSyV5.UseVisualStyleBackColor = true;
            this.btnSyV5.Click += new System.EventHandler(this.btnSyV5_Click);
            // 
            // btnSyH5
            // 
            this.btnSyH5.Location = new System.Drawing.Point(169, 107);
            this.btnSyH5.Margin = new System.Windows.Forms.Padding(2);
            this.btnSyH5.Name = "btnSyH5";
            this.btnSyH5.Size = new System.Drawing.Size(45, 25);
            this.btnSyH5.TabIndex = 24;
            this.btnSyH5.Text = "Sy H5";
            this.btnSyH5.UseVisualStyleBackColor = true;
            this.btnSyH5.Click += new System.EventHandler(this.btnSyH5_Click);
            // 
            // btnAnV5
            // 
            this.btnAnV5.Location = new System.Drawing.Point(119, 136);
            this.btnAnV5.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnV5.Name = "btnAnV5";
            this.btnAnV5.Size = new System.Drawing.Size(46, 25);
            this.btnAnV5.TabIndex = 23;
            this.btnAnV5.Text = "An V5";
            this.btnAnV5.UseVisualStyleBackColor = true;
            this.btnAnV5.Click += new System.EventHandler(this.btnAnV5_Click);
            // 
            // btnAnH5
            // 
            this.btnAnH5.Location = new System.Drawing.Point(119, 107);
            this.btnAnH5.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnH5.Name = "btnAnH5";
            this.btnAnH5.Size = new System.Drawing.Size(46, 25);
            this.btnAnH5.TabIndex = 22;
            this.btnAnH5.Text = "An H5";
            this.btnAnH5.UseVisualStyleBackColor = true;
            this.btnAnH5.Click += new System.EventHandler(this.btnAnH5_Click);
            // 
            // btnSyV4
            // 
            this.btnSyV4.Location = new System.Drawing.Point(169, 64);
            this.btnSyV4.Margin = new System.Windows.Forms.Padding(2);
            this.btnSyV4.Name = "btnSyV4";
            this.btnSyV4.Size = new System.Drawing.Size(45, 25);
            this.btnSyV4.TabIndex = 21;
            this.btnSyV4.Text = "Sy V4";
            this.btnSyV4.UseVisualStyleBackColor = true;
            this.btnSyV4.Click += new System.EventHandler(this.btnSyV4_Click);
            // 
            // btnSyH4
            // 
            this.btnSyH4.Location = new System.Drawing.Point(169, 34);
            this.btnSyH4.Margin = new System.Windows.Forms.Padding(2);
            this.btnSyH4.Name = "btnSyH4";
            this.btnSyH4.Size = new System.Drawing.Size(45, 25);
            this.btnSyH4.TabIndex = 20;
            this.btnSyH4.Text = "Sy H4";
            this.btnSyH4.UseVisualStyleBackColor = true;
            this.btnSyH4.Click += new System.EventHandler(this.btnSyH4_Click);
            // 
            // btnAnV4
            // 
            this.btnAnV4.Location = new System.Drawing.Point(119, 63);
            this.btnAnV4.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnV4.Name = "btnAnV4";
            this.btnAnV4.Size = new System.Drawing.Size(46, 25);
            this.btnAnV4.TabIndex = 19;
            this.btnAnV4.Text = "An V4";
            this.btnAnV4.UseVisualStyleBackColor = true;
            this.btnAnV4.Click += new System.EventHandler(this.btnAnV4_Click);
            // 
            // btnAnH4
            // 
            this.btnAnH4.Location = new System.Drawing.Point(119, 34);
            this.btnAnH4.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnH4.Name = "btnAnH4";
            this.btnAnH4.Size = new System.Drawing.Size(46, 25);
            this.btnAnH4.TabIndex = 18;
            this.btnAnH4.Text = "An H4";
            this.btnAnH4.UseVisualStyleBackColor = true;
            this.btnAnH4.Click += new System.EventHandler(this.btnAnH4_Click);
            // 
            // btnSyV3
            // 
            this.btnSyV3.Location = new System.Drawing.Point(57, 213);
            this.btnSyV3.Margin = new System.Windows.Forms.Padding(2);
            this.btnSyV3.Name = "btnSyV3";
            this.btnSyV3.Size = new System.Drawing.Size(45, 25);
            this.btnSyV3.TabIndex = 17;
            this.btnSyV3.Text = "Sy V3";
            this.btnSyV3.UseVisualStyleBackColor = true;
            this.btnSyV3.Click += new System.EventHandler(this.btnSyV3_Click);
            // 
            // btnSyH3
            // 
            this.btnSyH3.Location = new System.Drawing.Point(57, 183);
            this.btnSyH3.Margin = new System.Windows.Forms.Padding(2);
            this.btnSyH3.Name = "btnSyH3";
            this.btnSyH3.Size = new System.Drawing.Size(45, 25);
            this.btnSyH3.TabIndex = 16;
            this.btnSyH3.Text = "Sy H3";
            this.btnSyH3.UseVisualStyleBackColor = true;
            this.btnSyH3.Click += new System.EventHandler(this.btnSyH3_Click);
            // 
            // btnAnV3
            // 
            this.btnAnV3.Location = new System.Drawing.Point(7, 213);
            this.btnAnV3.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnV3.Name = "btnAnV3";
            this.btnAnV3.Size = new System.Drawing.Size(46, 25);
            this.btnAnV3.TabIndex = 15;
            this.btnAnV3.Text = "An V3";
            this.btnAnV3.UseVisualStyleBackColor = true;
            this.btnAnV3.Click += new System.EventHandler(this.btnAnV3_Click);
            // 
            // btnAnH3
            // 
            this.btnAnH3.Location = new System.Drawing.Point(7, 183);
            this.btnAnH3.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnH3.Name = "btnAnH3";
            this.btnAnH3.Size = new System.Drawing.Size(46, 25);
            this.btnAnH3.TabIndex = 14;
            this.btnAnH3.Text = "An H3";
            this.btnAnH3.UseVisualStyleBackColor = true;
            this.btnAnH3.Click += new System.EventHandler(this.btnAnH3_Click);
            // 
            // btnSyv2
            // 
            this.btnSyv2.Location = new System.Drawing.Point(57, 137);
            this.btnSyv2.Margin = new System.Windows.Forms.Padding(2);
            this.btnSyv2.Name = "btnSyv2";
            this.btnSyv2.Size = new System.Drawing.Size(45, 25);
            this.btnSyv2.TabIndex = 13;
            this.btnSyv2.Text = "Sy V2";
            this.btnSyv2.UseVisualStyleBackColor = true;
            this.btnSyv2.Click += new System.EventHandler(this.btnSyv2_Click);
            // 
            // btnSyH2
            // 
            this.btnSyH2.Location = new System.Drawing.Point(57, 107);
            this.btnSyH2.Margin = new System.Windows.Forms.Padding(2);
            this.btnSyH2.Name = "btnSyH2";
            this.btnSyH2.Size = new System.Drawing.Size(45, 25);
            this.btnSyH2.TabIndex = 12;
            this.btnSyH2.Text = "Sy H2";
            this.btnSyH2.UseVisualStyleBackColor = true;
            this.btnSyH2.Click += new System.EventHandler(this.btnSyH2_Click);
            // 
            // btnAnV2
            // 
            this.btnAnV2.Location = new System.Drawing.Point(7, 137);
            this.btnAnV2.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnV2.Name = "btnAnV2";
            this.btnAnV2.Size = new System.Drawing.Size(46, 25);
            this.btnAnV2.TabIndex = 11;
            this.btnAnV2.Text = "An V2";
            this.btnAnV2.UseVisualStyleBackColor = true;
            this.btnAnV2.Click += new System.EventHandler(this.btnAnV2_Click);
            // 
            // btnAnH2
            // 
            this.btnAnH2.Location = new System.Drawing.Point(7, 107);
            this.btnAnH2.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnH2.Name = "btnAnH2";
            this.btnAnH2.Size = new System.Drawing.Size(46, 25);
            this.btnAnH2.TabIndex = 10;
            this.btnAnH2.Text = "An H2";
            this.btnAnH2.UseVisualStyleBackColor = true;
            this.btnAnH2.Click += new System.EventHandler(this.btnAnH2_Click);
            // 
            // btnShowWavelet
            // 
            this.btnShowWavelet.Location = new System.Drawing.Point(126, 270);
            this.btnShowWavelet.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowWavelet.Name = "btnShowWavelet";
            this.btnShowWavelet.Size = new System.Drawing.Size(77, 25);
            this.btnShowWavelet.TabIndex = 9;
            this.btnShowWavelet.Text = "Show XY";
            this.btnShowWavelet.UseVisualStyleBackColor = true;
            this.btnShowWavelet.Click += new System.EventHandler(this.btnShowWavelet_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(22, 270);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 25);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSyV1
            // 
            this.btnSyV1.Location = new System.Drawing.Point(57, 63);
            this.btnSyV1.Margin = new System.Windows.Forms.Padding(2);
            this.btnSyV1.Name = "btnSyV1";
            this.btnSyV1.Size = new System.Drawing.Size(45, 25);
            this.btnSyV1.TabIndex = 7;
            this.btnSyV1.Text = "Sy V1";
            this.btnSyV1.UseVisualStyleBackColor = true;
            this.btnSyV1.Click += new System.EventHandler(this.btnSyV1_Click);
            // 
            // btnSyH1
            // 
            this.btnSyH1.Location = new System.Drawing.Point(57, 34);
            this.btnSyH1.Margin = new System.Windows.Forms.Padding(2);
            this.btnSyH1.Name = "btnSyH1";
            this.btnSyH1.Size = new System.Drawing.Size(45, 25);
            this.btnSyH1.TabIndex = 6;
            this.btnSyH1.Text = "Sy H1";
            this.btnSyH1.UseVisualStyleBackColor = true;
            this.btnSyH1.Click += new System.EventHandler(this.btnSyH1_Click);
            // 
            // btnAnV1
            // 
            this.btnAnV1.Location = new System.Drawing.Point(7, 63);
            this.btnAnV1.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnV1.Name = "btnAnV1";
            this.btnAnV1.Size = new System.Drawing.Size(46, 25);
            this.btnAnV1.TabIndex = 5;
            this.btnAnV1.Text = "An V1";
            this.btnAnV1.UseVisualStyleBackColor = true;
            this.btnAnV1.Click += new System.EventHandler(this.btnAnV1_Click);
            // 
            // btnAnH1
            // 
            this.btnAnH1.Location = new System.Drawing.Point(7, 34);
            this.btnAnH1.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnH1.Name = "btnAnH1";
            this.btnAnH1.Size = new System.Drawing.Size(46, 25);
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
            // btnSaveEncodedWVL
            // 
            this.btnSaveEncodedWVL.Location = new System.Drawing.Point(634, 550);
            this.btnSaveEncodedWVL.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveEncodedWVL.Name = "btnSaveEncodedWVL";
            this.btnSaveEncodedWVL.Size = new System.Drawing.Size(56, 25);
            this.btnSaveEncodedWVL.TabIndex = 14;
            this.btnSaveEncodedWVL.Text = "Save";
            this.btnSaveEncodedWVL.UseVisualStyleBackColor = true;
            this.btnSaveEncodedWVL.Click += new System.EventHandler(this.btnSaveEncodedWVL_Click);
            // 
            // btnLoadWVL
            // 
            this.btnLoadWVL.Location = new System.Drawing.Point(552, 550);
            this.btnLoadWVL.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadWVL.Name = "btnLoadWVL";
            this.btnLoadWVL.Size = new System.Drawing.Size(78, 25);
            this.btnLoadWVL.TabIndex = 8;
            this.btnLoadWVL.Text = "Load WVL";
            this.btnLoadWVL.UseVisualStyleBackColor = true;
            this.btnLoadWVL.Click += new System.EventHandler(this.btnLoadWVL_Click);
            // 
            // groupBoxErrorValueMinMax
            // 
            this.groupBoxErrorValueMinMax.Controls.Add(this.btnVerifyError);
            this.groupBoxErrorValueMinMax.Controls.Add(this.label11);
            this.groupBoxErrorValueMinMax.Controls.Add(this.label10);
            this.groupBoxErrorValueMinMax.Controls.Add(this.textBoxMaxErrorValue);
            this.groupBoxErrorValueMinMax.Controls.Add(this.textBoxMinErrorValue);
            this.groupBoxErrorValueMinMax.Location = new System.Drawing.Point(1076, 447);
            this.groupBoxErrorValueMinMax.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxErrorValueMinMax.Name = "groupBoxErrorValueMinMax";
            this.groupBoxErrorValueMinMax.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxErrorValueMinMax.Size = new System.Drawing.Size(220, 128);
            this.groupBoxErrorValueMinMax.TabIndex = 15;
            this.groupBoxErrorValueMinMax.TabStop = false;
            this.groupBoxErrorValueMinMax.Text = "Error (original - wavelet)";
            // 
            // btnVerifyError
            // 
            this.btnVerifyError.Location = new System.Drawing.Point(10, 88);
            this.btnVerifyError.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerifyError.Name = "btnVerifyError";
            this.btnVerifyError.Size = new System.Drawing.Size(74, 31);
            this.btnVerifyError.TabIndex = 19;
            this.btnVerifyError.Text = "Test Error";
            this.btnVerifyError.UseVisualStyleBackColor = true;
            this.btnVerifyError.Click += new System.EventHandler(this.btnVerifyError_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 59);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Max value :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Min value :";
            // 
            // textBoxMaxErrorValue
            // 
            this.textBoxMaxErrorValue.Location = new System.Drawing.Point(105, 57);
            this.textBoxMaxErrorValue.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaxErrorValue.Name = "textBoxMaxErrorValue";
            this.textBoxMaxErrorValue.ReadOnly = true;
            this.textBoxMaxErrorValue.Size = new System.Drawing.Size(76, 20);
            this.textBoxMaxErrorValue.TabIndex = 13;
            // 
            // textBoxMinErrorValue
            // 
            this.textBoxMinErrorValue.Location = new System.Drawing.Point(105, 23);
            this.textBoxMinErrorValue.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMinErrorValue.Name = "textBoxMinErrorValue";
            this.textBoxMinErrorValue.ReadOnly = true;
            this.textBoxMinErrorValue.Size = new System.Drawing.Size(76, 20);
            this.textBoxMinErrorValue.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1311, 586);
            this.Controls.Add(this.groupBoxErrorValueMinMax);
            this.Controls.Add(this.btnSaveEncodedWVL);
            this.Controls.Add(this.btnLoadWVL);
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
            this.groupBoxErrorValueMinMax.ResumeLayout(false);
            this.groupBoxErrorValueMinMax.PerformLayout();
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
        private System.Windows.Forms.Button btnSaveEncodedWVL;
        private System.Windows.Forms.Button btnLoadWVL;
        private System.Windows.Forms.GroupBox groupBoxErrorValueMinMax;
        private System.Windows.Forms.Button btnVerifyError;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxMaxErrorValue;
        private System.Windows.Forms.TextBox textBoxMinErrorValue;
        private System.Windows.Forms.Button btnSyv2;
        private System.Windows.Forms.Button btnSyH2;
        private System.Windows.Forms.Button btnAnV2;
        private System.Windows.Forms.Button btnAnH2;
        private System.Windows.Forms.Button btnSyV3;
        private System.Windows.Forms.Button btnSyH3;
        private System.Windows.Forms.Button btnAnV3;
        private System.Windows.Forms.Button btnAnH3;
        private System.Windows.Forms.Button btnSyV5;
        private System.Windows.Forms.Button btnSyH5;
        private System.Windows.Forms.Button btnAnV5;
        private System.Windows.Forms.Button btnAnH5;
        private System.Windows.Forms.Button btnSyV4;
        private System.Windows.Forms.Button btnSyH4;
        private System.Windows.Forms.Button btnAnV4;
        private System.Windows.Forms.Button btnAnH4;
    }
}

