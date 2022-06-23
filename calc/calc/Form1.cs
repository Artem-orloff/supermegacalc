using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public string operation;
        public string firstArgument, secondArgument;

        public Form1()
        {
            InitializeComponent();
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_click(object sender, EventArgs e)
        {
            Button A = (Button)sender;
            operation = A.Text;
            firstArgument = textBox10.Text;
            secondArgument = textBox11.Text;

            firstNum = Convert.ToDouble(firstArgument);
            secondNum = Convert.ToDouble(secondArgument);
        }
    }
}
