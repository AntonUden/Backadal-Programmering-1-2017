namespace _8._2
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
            this.valueR = new System.Windows.Forms.TrackBar();
            this.lableR = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.valueG = new System.Windows.Forms.TrackBar();
            this.valueB = new System.Windows.Forms.TrackBar();
            this.labelB = new System.Windows.Forms.Label();
            this.rgbValue = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.colorDialogOpen = new System.Windows.Forms.Button();
            this.drawArea = new System.Windows.Forms.Panel();
            this.randColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.valueR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueB)).BeginInit();
            this.SuspendLayout();
            // 
            // valueR
            // 
            this.valueR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueR.Location = new System.Drawing.Point(36, 12);
            this.valueR.Maximum = 255;
            this.valueR.Name = "valueR";
            this.valueR.Size = new System.Drawing.Size(236, 45);
            this.valueR.TabIndex = 0;
            this.valueR.Scroll += new System.EventHandler(this.value_Scroll);
            // 
            // lableR
            // 
            this.lableR.AutoSize = true;
            this.lableR.Location = new System.Drawing.Point(12, 12);
            this.lableR.Name = "lableR";
            this.lableR.Size = new System.Drawing.Size(18, 13);
            this.lableR.TabIndex = 1;
            this.lableR.Text = "R:";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Location = new System.Drawing.Point(12, 63);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(18, 13);
            this.labelG.TabIndex = 2;
            this.labelG.Text = "G:";
            // 
            // valueG
            // 
            this.valueG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueG.Location = new System.Drawing.Point(36, 63);
            this.valueG.Maximum = 255;
            this.valueG.Name = "valueG";
            this.valueG.Size = new System.Drawing.Size(236, 45);
            this.valueG.TabIndex = 3;
            this.valueG.Scroll += new System.EventHandler(this.value_Scroll);
            // 
            // valueB
            // 
            this.valueB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueB.Location = new System.Drawing.Point(36, 114);
            this.valueB.Maximum = 255;
            this.valueB.Name = "valueB";
            this.valueB.Size = new System.Drawing.Size(236, 45);
            this.valueB.TabIndex = 4;
            this.valueB.Scroll += new System.EventHandler(this.value_Scroll);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(12, 114);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(17, 13);
            this.labelB.TabIndex = 5;
            this.labelB.Text = "B:";
            // 
            // rgbValue
            // 
            this.rgbValue.AutoSize = true;
            this.rgbValue.Location = new System.Drawing.Point(12, 149);
            this.rgbValue.Name = "rgbValue";
            this.rgbValue.Size = new System.Drawing.Size(114, 13);
            this.rgbValue.TabIndex = 6;
            this.rgbValue.Text = "R: 255, G: 255, B: 255";
            // 
            // colorDialogOpen
            // 
            this.colorDialogOpen.Location = new System.Drawing.Point(12, 165);
            this.colorDialogOpen.Name = "colorDialogOpen";
            this.colorDialogOpen.Size = new System.Drawing.Size(114, 23);
            this.colorDialogOpen.TabIndex = 7;
            this.colorDialogOpen.Text = "Open color dialog";
            this.colorDialogOpen.UseVisualStyleBackColor = true;
            this.colorDialogOpen.Click += new System.EventHandler(this.colorDialogOpen_Click);
            // 
            // drawArea
            // 
            this.drawArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawArea.BackColor = System.Drawing.Color.White;
            this.drawArea.Location = new System.Drawing.Point(12, 194);
            this.drawArea.Name = "drawArea";
            this.drawArea.Size = new System.Drawing.Size(260, 155);
            this.drawArea.TabIndex = 8;
            this.drawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.drawArea_Paint);
            // 
            // randColor
            // 
            this.randColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.randColor.Location = new System.Drawing.Point(158, 165);
            this.randColor.Name = "randColor";
            this.randColor.Size = new System.Drawing.Size(114, 23);
            this.randColor.TabIndex = 9;
            this.randColor.Text = "Random color";
            this.randColor.UseVisualStyleBackColor = true;
            this.randColor.Click += new System.EventHandler(this.randColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.randColor);
            this.Controls.Add(this.drawArea);
            this.Controls.Add(this.colorDialogOpen);
            this.Controls.Add(this.rgbValue);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.valueB);
            this.Controls.Add(this.valueG);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.lableR);
            this.Controls.Add(this.valueR);
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "Form1";
            this.Text = "Colors";
            ((System.ComponentModel.ISupportInitialize)(this.valueR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar valueR;
        private System.Windows.Forms.Label lableR;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.TrackBar valueG;
        private System.Windows.Forms.TrackBar valueB;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label rgbValue;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button colorDialogOpen;
        private System.Windows.Forms.Panel drawArea;
        private System.Windows.Forms.Button randColor;
    }
}

