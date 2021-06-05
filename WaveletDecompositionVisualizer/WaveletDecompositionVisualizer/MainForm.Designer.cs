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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaveletImage)).BeginInit();
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1085, 695);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginalImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadBMP;
        private System.Windows.Forms.PictureBox pictureBoxWaveletImage;
        private System.Windows.Forms.Label label2;
    }
}

