using System;
using System.Windows.Forms;

namespace Is_vatten_eller_ånga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            updateState();
        }

        private void input_ValueChanged(object sender, EventArgs e)
        {
            updateState();
        }

        private void updateState()
        {
            try
            {
                double inputValue = double.Parse(input.Value.ToString());
                if (inputValue < 0)
                {
                    stateLabel.Text = "Is";
                }
                else if (inputValue >= 100)
                {
                    stateLabel.Text = "Ånga";
                }
                else
                {
                    stateLabel.Text = "Vatten";
                }
            } catch(Exception e)
            {
                stateLabel.Text = "Error";
            }
        }
    }
}
