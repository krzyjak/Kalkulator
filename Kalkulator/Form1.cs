using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public double firstNumber;
        public double secondNumber;
        public bool operationProof = false;

        enum Operation
        {
            plus,
            minus,
            multiplication,
            division
         }

        Operation operation = new Operation();
        
        readonly calculator calc = new calculator();

        public Form1()
        {
            InitializeComponent();
            display.Text = "0";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            calc.SecondNumber = Double.Parse(display.Text);
            display.Clear();

            switch (operation)
            {
                case Operation.plus:
                    display.Text = calc.AddNumbers(firstNumber, secondNumber).ToString();
                    break;
                case Operation.minus:
                    display.Text = calc.SubNumbers(firstNumber, secondNumber).ToString();
                    break;
                case Operation.multiplication:
                    display.Text = calc.MultiplyNumbers(firstNumber, secondNumber).ToString();
                    break;
                case Operation.division:
                    display.Text = calc.DivNumbers(firstNumber, secondNumber).ToString();
                    break;
            }
        }

        private void number_Click(object sender, EventArgs e)
        {
            if(operationProof)
            {
                operationProof = false;
                display.Clear();
            }

            if (display.Text == "0")
            {
                display.Clear();
            }
               
            display.AppendText(((Button)sender).Text);
        }
     

        private void operation_Click(object sender, EventArgs e)
        {
            operationProof = true;
            operation = (Operation)Enum.Parse(typeof(Operation),((Button)sender).AccessibleDescription);
            calc.FirstNumber = Double.Parse(display.Text);  
        }

        private void end_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
