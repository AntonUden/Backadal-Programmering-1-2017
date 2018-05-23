using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8._1
{
    public partial class Form1 : Form
    {
        public int x, y = 0;
        public Form1()
        {
            InitializeComponent();
            x = this.Width / 2;
            y = this.Height / 2;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush sb = new SolidBrush(Color.Aqua);

            if (x > this.Width)
                x = this.Width;

            y = this.Height / 2;

            g.FillRectangle(sb, x - 30, y - 30, 60, 60);
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            x -= 10;
            if (x < 0)
                x = 0;
            this.Invalidate();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            x += 10;
            if (x > this.Width)
                x = this.Width;
            this.Invalidate();
        }
    }
}
