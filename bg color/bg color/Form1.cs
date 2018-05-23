using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bg_color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void blue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void red_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void green_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }
    }
}
