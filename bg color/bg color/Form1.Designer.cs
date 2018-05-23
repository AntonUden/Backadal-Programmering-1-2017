namespace bg_color
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
            this.red = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(12, 12);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(75, 23);
            this.red.TabIndex = 0;
            this.red.Text = "Röd";
            this.red.UseVisualStyleBackColor = true;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // blue
            // 
            this.blue.Location = new System.Drawing.Point(197, 12);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(75, 23);
            this.blue.TabIndex = 1;
            this.blue.Text = "Blå";
            this.blue.UseVisualStyleBackColor = true;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(93, 12);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(98, 23);
            this.green.TabIndex = 2;
            this.green.Text = "Grön";
            this.green.UseVisualStyleBackColor = true;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(284, 49);
            this.Controls.Add(this.green);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.red);
            this.MaximumSize = new System.Drawing.Size(300, 88);
            this.MinimumSize = new System.Drawing.Size(300, 88);
            this.Name = "Form1";
            this.Text = "Uppgift";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button green;
    }
}

