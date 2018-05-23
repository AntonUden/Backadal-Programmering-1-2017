namespace _8._1
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
            this.btnL = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(12, 12);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(75, 23);
            this.btnL.TabIndex = 0;
            this.btnL.Text = "Vänster";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnR
            // 
            this.btnR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnR.Location = new System.Drawing.Point(197, 12);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(75, 23);
            this.btnR.TabIndex = 1;
            this.btnR.Text = "Höger";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnR;
    }
}

