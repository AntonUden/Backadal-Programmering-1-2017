﻿namespace Button
{
    partial class Form1
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
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(357, 45);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(102, 23);
            this.button.TabIndex = 0;
            this.button.Text = "You cant click me";
            this.button.UseVisualStyleBackColor = true;
            this.button.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 338);
            this.Controls.Add(this.button);
            this.MaximumSize = new System.Drawing.Size(881, 377);
            this.MinimumSize = new System.Drawing.Size(881, 377);
            this.Name = "Form1";
            this.Text = "Click the button";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button;
    }
}

