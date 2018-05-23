namespace Is_vatten_eller_ånga
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
            this.input = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.input)).BeginInit();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.DecimalPlaces = 4;
            this.input.Location = new System.Drawing.Point(12, 25);
            this.input.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.input.Minimum = new decimal(new int[] {
            276447232,
            23283,
            0,
            -2147483648});
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(260, 20);
            this.input.TabIndex = 0;
            this.input.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.input.ValueChanged += new System.EventHandler(this.input_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperaturen i celsius";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.stateLabel.Location = new System.Drawing.Point(12, 48);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(93, 31);
            this.stateLabel.TabIndex = 2;
            this.stateLabel.Text = "Vatten";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 88);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.MaximumSize = new System.Drawing.Size(300, 127);
            this.MinimumSize = new System.Drawing.Size(300, 127);
            this.Name = "Form1";
            this.Text = "Is, vatten eller ånga";
            ((System.ComponentModel.ISupportInitialize)(this.input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stateLabel;
    }
}

