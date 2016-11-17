using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Calculator_Forms
{
    public partial class Form1 : Form
    {
        private int calculate;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            double firstNumber = Convert.ToDouble(textBox1.Text);
            double secondNumber = Convert.ToDouble(textBox2.Text);
            double sum = 0;
            if(textBox1.Text!=string.Empty && textBox2.Text!=string.Empty)
            {
                switch (calculate)
                {
                    case 0:
                        sum = calc.addition(firstNumber, secondNumber);
                        break;
                    case 1:
                        sum = calc.subtraction(firstNumber, secondNumber);
                        break;
                    case 2:
                        sum = calc.multiplication(firstNumber, secondNumber);
                        break;
                    case 3:
                        if(secondNumber == 0d)
                        {
                            throw new Exception(string.Empty);
                        } 
                        else
                        {
                            sum = calc.division(firstNumber, secondNumber);
                        }
                        break;
                }
                MessageBox.Show("The result is " + sum.ToString());
            }
           else
            {
                MessageBox.Show("Some of blocks are still empty, please try again.");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                calculate = (int)Calculate.Addition;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked==true)
            {
                calculate = (int)Calculate.Subtraction;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked==true)
            {
                calculate = (int)Calculate.Multiplication;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton4.Checked==true)
            {
                calculate = (int)Calculate.Division;
            }
        }
    }
}
