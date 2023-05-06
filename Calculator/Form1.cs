﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{

    public partial class Form1 : Form
    {
        double firstNumber = 0, secondNumber = 0, result = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void jednako(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(label1.Text);
            if (label4.Text == "+")
                result = firstNumber + secondNumber;
            else if (label4.Text == "-")
                result = firstNumber - secondNumber;
            else if (label4.Text == "*")
                result = firstNumber * secondNumber;
            else if (label4.Text == "/")
                result = firstNumber / secondNumber;
            else if(label4.Text=="%")
                result = firstNumber % secondNumber;
            
            label1.Text = Convert.ToString(result);
        }

        private void sabiranje(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(label1.Text);
            label1.Text = "0";
            label4.Text = "+";

        }
        private void oduzimanje(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(label1.Text);
            label1.Text = "0";
            label4.Text = "-";
        }
        private void mnozenje(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(label1.Text);
            label1.Text = "0";
            label4.Text = "*";
        }

        private void deljenje(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(label1.Text);
            label1.Text = "0";
            label4.Text = "/";
        }

        private void moduo(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(label1.Text);
            label1.Text = "0";
            label2.Text = "%";
        }

        private void one(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "1";
            }
            else
            {
                label1.Text = label1.Text + "1";
            }

        }

        private void two(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "2";
            }
            else
            {
                label1.Text = label1.Text + "2";
            }
        }

        private void three(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "3";
            }
            else
            {
                label1.Text = label1.Text + "3";
            }
        }

        private void four(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "4";
            }
            else
            {
                label1.Text = label1.Text + "4";
            }
        }

        private void five(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "5";
            }
            else
            {
                label1.Text = label1.Text + "5";
            }
        }

        private void six(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "6";
            }
            else
            {
                label1.Text = label1.Text + "6";
            }
        }

        private void seven(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "7";
            }
            else
            {
                label1.Text = label1.Text + "7";
            }
        }

        private void eight(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "8";
            }
            else
            {
                label1.Text = label1.Text + "8";
            }
        }

        private void nine(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "9";
            }
            else
            {
                label1.Text = label1.Text + "9";
            }
        }

        private void nula(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void clear(object sender, EventArgs e)
        {
            label1.Text = "0";
            label4.Text = " ";
        }
    }
    
}
