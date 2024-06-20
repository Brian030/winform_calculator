using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double CalResult = 0.0;
        StringBuilder InputText = new StringBuilder(String.Empty);
        bool newInput = true;
        string OperationSign = String.Empty;
        bool firstNumber = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if(newInput)
            {
                InputText.Clear();
                InputText.Append("1");
                textBox1.Text = InputText.ToString();
            }
            else
            {
                InputText.Append("1");
                textBox1.Text = InputText.ToString();
            }
            newInput = false;
        }
        private void twoButton_Click(object sender, EventArgs e)
        {
            if (newInput)
            {
                InputText.Clear();
                InputText.Append("2");
                textBox1.Text = InputText.ToString();
            }
            else
            {
                InputText.Append("2");
                textBox1.Text = InputText.ToString();
            }
            newInput = false;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (newInput)
            {
                InputText.Clear();
                InputText.Append("3");
                textBox1.Text = InputText.ToString();
            }
            else
            {
                InputText.Append("3");
                textBox1.Text = InputText.ToString();
            }
            newInput = false;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (newInput)
            {
                InputText.Clear();
                InputText.Append("4");
                textBox1.Text = InputText.ToString();
            }
            else
            {
                InputText.Append("4");
                textBox1.Text = InputText.ToString();
            }
            newInput = false;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (newInput)
            {
                InputText.Clear();
                InputText.Append("5");
                textBox1.Text = InputText.ToString();
            }
            else
            {
                InputText.Append("5");
                textBox1.Text = InputText.ToString();
            }
            newInput = false;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (newInput)
            {
                InputText.Clear();
                InputText.Append("6");
                textBox1.Text = InputText.ToString();
            }
            else
            {
                InputText.Append("6");
                textBox1.Text = InputText.ToString();
            }
            newInput = false;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (newInput)
            {
                InputText.Clear();
                InputText.Append("7");
                textBox1.Text = InputText.ToString();
            }
            else
            {
                InputText.Append("7");
                textBox1.Text = InputText.ToString();
            }
            newInput = false;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (newInput)
            {
                InputText.Clear();
                InputText.Append("8");
                textBox1.Text = InputText.ToString();
            }
            else
            {
                InputText.Append("8");
                textBox1.Text = InputText.ToString();
            }
            newInput = false;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (newInput)
            {
                InputText.Clear();
                InputText.Append("9");
                textBox1.Text = InputText.ToString();
            }
            else
            {
                InputText.Append("9");
                textBox1.Text = InputText.ToString();
            }
            newInput = false;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (newInput)
            {
                InputText.Clear();
                InputText.Append("0");
                textBox1.Text = InputText.ToString();
            }
            else
            {
                InputText.Append("0");
                textBox1.Text = InputText.ToString();
            }
            newInput = false;
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            if (newInput)
            {
                InputText.Clear();
                InputText.Append("0.");
                textBox1.Text = InputText.ToString();
            }
            else
            {
                InputText.Append(".");
                textBox1.Text = InputText.ToString();
            }
            newInput = false;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if(firstNumber)
            {
                CalResult = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                CalResult += Convert.ToDouble(textBox1.Text);
            }
            
            textBox1.Text = Convert.ToString(CalResult);
            OperationSign = "+";
            newInput = true;
            firstNumber = false;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (firstNumber)
            {
                CalResult = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                CalResult -= Convert.ToDouble(textBox1.Text);
            }

            textBox1.Text = Convert.ToString(CalResult);
            OperationSign = "-";
            newInput = true;
            firstNumber = false;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (firstNumber)
            {
                CalResult = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                CalResult *= Convert.ToDouble(textBox1.Text);
            }

            textBox1.Text = Convert.ToString(CalResult);
            OperationSign = "x";
            newInput = true;
            firstNumber = false;
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            if (firstNumber)
            {
                CalResult = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                CalResult /= Convert.ToDouble(textBox1.Text);
            }

            textBox1.Text = Convert.ToString(CalResult);
            OperationSign = "/";
            newInput = true;
            firstNumber = false;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if(OperationSign == "+")
            {
                CalResult += Convert.ToDouble(textBox1.Text);
            }
            else if(OperationSign == "-")
            {
                CalResult -= Convert.ToDouble(textBox1.Text);
            }
            else if(OperationSign == "x")
            {
                CalResult *= Convert.ToDouble(textBox1.Text);
            }
            else
            {
                CalResult /= Convert.ToDouble(textBox1.Text);
            }
            textBox1.Text = Convert.ToString(CalResult);
            newInput = true;
            OperationSign = String.Empty;
            firstNumber = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            InputText.Clear();
            CalResult = 0.0;
            newInput = true;
            OperationSign = String.Empty;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            InputText.Clear();
            InputText.Append(textBox1.Text);
            if (InputText.Length >= 1)
            {
                InputText.Remove(InputText.Length - 1, 1);
            }
            textBox1.Text = InputText.ToString();
        }
    }
}
