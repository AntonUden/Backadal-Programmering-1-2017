using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8._2
{
    public partial class Form1 : Form
    {
        public int r, g, b = 0;
        public Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            r = rand.Next(255);
            g = rand.Next(255);
            b = rand.Next(255);
            valueR.Value = r;
            valueG.Value = g;
            valueB.Value = b;
            this.Invalidate();
        }

        private void colorDialogOpen_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Color.FromArgb(255, valueR.Value, valueG.Value, valueB.Value);
            colorDialog.ShowDialog();

            valueR.Value = colorDialog.Color.R;
            valueG.Value = colorDialog.Color.G;
            valueB.Value = colorDialog.Color.B;

            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            r = valueR.Value;
            g = valueG.Value;
            b = valueB.Value;

            rgbValue.Text = "R: " + r + " G: " + g + " B: " + b;
            drawArea.Invalidate();
            
        }

        private void randColor_Click(object sender, EventArgs e)
        {
            r = rand.Next(255);
            g = rand.Next(255);
            b = rand.Next(255);
            valueR.Value = r;
            valueG.Value = g;
            valueB.Value = b;
            this.Invalidate();
        }

        private void value_Scroll(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void drawArea_Paint(object sender, PaintEventArgs e)
        {
            int boxSize = 3;
            Graphics gr = e.Graphics;
            Pen p = new Pen(Color.Black);
            SolidBrush sb = new SolidBrush(Color.FromArgb(255, r, g, b));

            p.Width = 2;
            gr.FillRectangle(sb, drawArea.Width / 2 - drawArea.Width / boxSize, drawArea.Height / 2 - drawArea.Height / boxSize, (drawArea.Width / boxSize) * 2, (drawArea.Height / boxSize) * 2);
            gr.DrawRectangle(p, 0, 0, drawArea.Width, drawArea.Height);
        }
    }
}
