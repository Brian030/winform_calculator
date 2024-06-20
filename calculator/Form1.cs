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
            AddNumber("1");
        }
        private void twoButton_Click(object sender, EventArgs e)
        {
            AddNumber("2");
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            AddNumber("3");
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            AddNumber("4");
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            AddNumber("5");
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            AddNumber("6");
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            AddNumber("7");
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            AddNumber("8");
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            AddNumber("9");
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            AddNumber("0");
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            if (newInput)
            {
                InputText.Clear();
                InputText.Append("0.");
                textBox1.Text = InputText.ToString();
            }
            else if(textBox1.Text.IndexOf(".") == -1) //沒有輸入過 "."
            {
                InputText.Append(".");
                textBox1.Text = InputText.ToString();
            }
            newInput = false;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            DoOperation("+");
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            DoOperation("-");
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            DoOperation("x");
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            DoOperation("/");
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
            else if(OperationSign == "/")
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
            firstNumber = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            InputText.Clear();
            InputText.Append(textBox1.Text);
            if (InputText.Length >= 1 && newInput)
            {
                InputText.Remove(InputText.Length - 1, 1);
            }
            textBox1.Text = InputText.ToString();
        }

        private void AddNumber(string number)
        {
            if (newInput)
            {
                InputText.Clear();
                InputText.Append(number);
                textBox1.Text = InputText.ToString();
            }
            else
            {
                InputText.Append(number);
                textBox1.Text = InputText.ToString();
            }
            newInput = false;
        }

        private void DoOperation(string operation)
        {
            if (firstNumber)
            {
                CalResult = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                if(operation == "+")
                {
                    CalResult += Convert.ToDouble(textBox1.Text);
                    
                }
                else if(operation  == "-")
                {
                    CalResult -= Convert.ToDouble(textBox1.Text);
                }
                else if(operation == "x")
                {
                    CalResult *= Convert.ToDouble(textBox1.Text);
                }
                else if (OperationSign == "/")
                {
                    CalResult /= Convert.ToDouble(textBox1.Text);
                }
                
            }
            OperationSign = operation;
            textBox1.Text = Convert.ToString(CalResult);
            newInput = true;
            firstNumber = false;
        }
    }
}
