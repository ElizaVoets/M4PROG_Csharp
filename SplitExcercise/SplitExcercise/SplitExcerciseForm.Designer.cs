﻿
namespace SplitExcercise
{
    partial class SplitExcerciseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gen
            // 
            this.gen.Location = new System.Drawing.Point(866, 52);
            this.gen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(118, 36);
            this.gen.TabIndex = 0;
            this.gen.Text = "gen";
            this.gen.UseVisualStyleBackColor = true;
            this.gen.Click += new System.EventHandler(this.gen_Click);
            // 
            // SplitExcerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.gen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SplitExcerciseForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gen;
    }
}

