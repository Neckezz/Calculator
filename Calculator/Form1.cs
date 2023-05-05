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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void smesteni_brojevi(int x)
        {
            while (x)
            {
                label3.Text = x + " ";
            }
            
        }

        private void sabiranje(object sender, EventArgs e)
        {
            label2.Text = "+";
        }
        private void oduzimanje(object sender, EventArgs e)
        {
            label2.Text = "-";
        }
        private void mnozenje(object sender, EventArgs e)
        {
            label2.Text = "*";
        }
        private void deljenje(object sender, EventArgs e)
        {
            label2.Text = "/";
        }

        private void button13_Click(object sender, EventArgs e) //C
        {
            label1.Text = "O";
        }

        private void modul(object sender, EventArgs e)
        {
            label2.Text = "%";
        }
    }
    
}
namespace Calculator
{
    public partial class Form1:Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            int zero = 0;
            label1.Text = "0 ";
            smesteni_brojevi(zero);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int one = 1;
            label1.Text = "1 ";
            smesteni_brojevi(one);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int two = 2;
            label1.Text = "2 ";
            smesteni_brojevi(two);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int three = 3;
            label1.Text = "3 ";
            smesteni_brojevi(three);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int four = 4;
            label1.Text = "4 ";
            smesteni_brojevi(four);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int five = 5;
            label1.Text = "5 ";
            smesteni_brojevi(five);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int six = 6;
            label1.Text = "6 ";
            smesteni_brojevi(six);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int seven = 7;
            label1.Text = "7 ";
            smesteni_brojevi(seven);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int eight = 8;
            label1.Text = "8 ";
            smesteni_brojevi(eight);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int nine = 9;
            label1.Text = "9 ";
            smesteni_brojevi(nine);
        }
    }
}
    




