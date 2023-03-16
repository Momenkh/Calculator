using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorByMomen : Form
    {
        float first;
        float second;
        bool firstOP = true;
        int op = 0;
        public CalculatorByMomen()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(this.Width, this.Height);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text += "0";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (firstOP)
            {
                op = 1;
                firstOP = false;
            }
            if (textBoxCalc.Text != "")
            {
                    second = float.Parse(textBoxCalc.Text);
                    equals(first, second);

            }
            op = 1;
            resultBox.Text = first.ToString();             
            textBoxCalc.Text = string.Empty;
            
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (firstOP)
            {
                op = 2;
                firstOP = false;
            }
            if (textBoxCalc.Text != "")
            {
                if (firstOP) { first = float.Parse(textBoxCalc.Text); }
                second = float.Parse(textBoxCalc.Text);
                equals(first, second);            

            }
            op = 2;
            resultBox.Text = first.ToString();
            textBoxCalc.Text = string.Empty;
        }
    

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (firstOP)
            {
                op = 3;
                firstOP = false;
            }
            if (textBoxCalc.Text != "")
            {
                if (firstOP) { first = float.Parse(textBoxCalc.Text); }
                second = float.Parse(textBoxCalc.Text);
                equals(first, second);

            }
            op = 3;
            resultBox.Text = first.ToString();
            textBoxCalc.Text = string.Empty;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (firstOP)
            {
                op = 4;
                firstOP = false;
            }
            if (textBoxCalc.Text != "")
            {
                if (firstOP) { first = float.Parse(textBoxCalc.Text); }
                second = float.Parse(textBoxCalc.Text);
                equals(first, second);

            }
            op = 4;
            resultBox.Text = first.ToString();
            textBoxCalc.Text = string.Empty;
        }

        private void equals(float f, float s) {
            switch (op)
            {
                case 1:
                    first = f + s;
                    break;
                case 2:
                    first = f - s;
                    break;
                case 3:
                    first = f * s;
                    break;
                case 4:
                    first = f / s;
                    break;
                default:
                    break;
            }
            op = 0;
            textBoxCalc.Text = first.ToString();
            resultBox.Text = "";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            first = second = 0;
            textBoxCalc.Text = string.Empty;
            resultBox.Text = string.Empty;
            firstOP = true;
            op = 0;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if (textBoxCalc.Text != "" && firstOP != true)
            {
                equals(first, float.Parse(textBoxCalc.Text));
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            string st = textBoxCalc.Text.Remove(textBoxCalc.TextLength - 1, 1);
            textBoxCalc.Text = st;
        }
    }
}
