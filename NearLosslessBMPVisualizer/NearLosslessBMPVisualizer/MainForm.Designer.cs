﻿namespace NearLosslessBMPVisualizer
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOriginalImage
            // 
            this.pictureBoxOriginalImage.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxOriginalImage.Location = new System.Drawing.Point(12, 42);
            this.pictureBoxOriginalImage.Name = "pictureBoxOriginalImage";
            this.pictureBoxOriginalImage.Size = new System.Drawing.Size(294, 289);
            this.pictureBoxOriginalImage.TabIndex = 0;
            this.pictureBoxOriginalImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original Image";
            // 
            // btnLoadBMP
            // 
            this.btnLoadBMP.Location = new System.Drawing.Point(12, 346);
            this.btnLoadBMP.Name = "btnLoadBMP";
            this.btnLoadBMP.Size = new System.Drawing.Size(75, 31);
            this.btnLoadBMP.TabIndex = 2;
            this.btnLoadBMP.Text = "Load";
            this.btnLoadBMP.UseVisualStyleBackColor = true;
            this.btnLoadBMP.Click += new System.EventHandler(this.btnLoadBMP_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1053, 642);
            this.Controls.Add(this.btnLoadBMP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxOriginalImage);
            this.Name = "MainForm";
            this.Text = "Near-Lossless Grayscale BMP Visualizer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginalImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadBMP;
    }
}

