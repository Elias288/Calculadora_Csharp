using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Csharp
{
    public partial class Form1 : Form
    {
        private string operation = "";
        private string firstNumber, secondNumber;
        Calculadora calc = new Calculadora();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNum0_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                firstNumber = firstNumber + "0";
            }
            else
            {
                secondNumber = secondNumber + "0";
            }

            textBox1.Text = textBox1.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                firstNumber = firstNumber + "1";
            }
            else
            {
                secondNumber = secondNumber + "1";
            }

            textBox1.Text = textBox1.Text + "1";
        }

        private void buttonNum2_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                firstNumber = firstNumber + "2";
            }
            else
            {
                secondNumber = secondNumber + "2";
            }

            textBox1.Text = textBox1.Text + "2";
        }

        private void buttonNum3_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                firstNumber = firstNumber + "3";
            }
            else
            {
                secondNumber = secondNumber + "3";
            }

            textBox1.Text = textBox1.Text + "3";
        }

        private void buttonNum4_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                firstNumber = firstNumber + "4";
            }
            else
            {
                secondNumber = secondNumber + "4";
            }

            textBox1.Text = textBox1.Text + "4";
        }

        private void buttonNum5_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                firstNumber = firstNumber + "5";
            }
            else
            {
                secondNumber = secondNumber + "5";
            }
            textBox1.Text = textBox1.Text + "5";
        }

        private void buttonNum6_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                firstNumber = firstNumber + "6";
            }
            else
            {
                secondNumber = secondNumber + "6";
            }
            textBox1.Text = textBox1.Text + "6";
        }

        private void buttonNum7_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                firstNumber = firstNumber + "7";
            }
            else
            {
                secondNumber = secondNumber + "7";
            }
            textBox1.Text = textBox1.Text + "7";
        }

        private void buttonNum8_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                firstNumber = firstNumber + "8";
            }
            else
            {
                secondNumber = secondNumber + "8";
            }
            textBox1.Text = textBox1.Text + "8";
        }

        private void buttonNum9_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                firstNumber = firstNumber + "9";
            }
            else
            {
                secondNumber = secondNumber + "9";
            }
            textBox1.Text = textBox1.Text + "9";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {

        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " =\t" + calc.Operar(operation, int.Parse(firstNumber), int.Parse(secondNumber));
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " + ";
            operation = "suma";
        }

        private void buttonRest_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " - ";
            operation = "resta";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " x ";
            operation = "multi";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + " / ";
            operation = "div";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            operation = "";
            firstNumber = "";
            secondNumber = "";
            textBox1.Text = "";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

        }
    }
}
