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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxHistogram = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogram)).BeginInit();
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
            this.btnRefresh.Location = new System.Drawing.Point(855, 551);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 31);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Histogram";
            // 
            // pictureBoxHistogram
            // 
            this.pictureBoxHistogram.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxHistogram.Location = new System.Drawing.Point(379, 177);
            this.pictureBoxHistogram.Name = "pictureBoxHistogram";
            this.pictureBoxHistogram.Size = new System.Drawing.Size(642, 346);
            this.pictureBoxHistogram.TabIndex = 6;
            this.pictureBoxHistogram.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1053, 642);
            this.Controls.Add(this.pictureBoxHistogram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnLoadBMP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxOriginalImage);
            this.Name = "MainForm";
            this.Text = "Near-Lossless Grayscale BMP Visualizer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginalImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadBMP;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxHistogram;
    }
}

