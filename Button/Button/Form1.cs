using System;
using System.Drawing;
using System.Windows.Forms;

namespace Button
{
    public partial class Form1 : Form
    {
        public int[] xPos = { 92, 636, 646, 323, 58, 357 };
        public int[] yPos = { 66, 167, 40, 205, 280, 45  };

        public int i = 0;

        public Form1()
        {
            InitializeComponent();
            button.Location = new Point(xPos[i], yPos[i]);
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            i++;
            button.Location = new Point(xPos[i], yPos[i]);
            if (i == xPos.Length- 1)
            {
                i = -1;
            }
        }
    }
}
