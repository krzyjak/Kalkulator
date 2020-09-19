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
        int pierwsza_liczba;
        int druga_liczba;

        byte dzialanie;
        bool klawisz_dzialania = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void end_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (klawisz_dzialania)
            {
                display.Clear();
                klawisz_dzialania = false;
            }

            display.AppendText("0");
        }

        private void one_Click(object sender, EventArgs e)
        {

            if (klawisz_dzialania)
            {
                display.Clear();
                klawisz_dzialania = false;
            }

            display.AppendText("1"); 
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (klawisz_dzialania)
            {
                display.Clear();
                klawisz_dzialania = false;
            }
            display.AppendText("2");
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (klawisz_dzialania)
            {
                display.Clear();
                klawisz_dzialania = false;
            }
            display.AppendText("3");
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (klawisz_dzialania)
            {
                display.Clear();
                klawisz_dzialania = false;
            }

            display.AppendText("4");
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (klawisz_dzialania)
            {
                display.Clear();
                klawisz_dzialania = false;
            }

            display.AppendText("5");
        }

        private void six_Click(object sender, EventArgs e)
        {

            if (klawisz_dzialania)
            {
                display.Clear();
                klawisz_dzialania = false;
            }
            display.AppendText("6");
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (klawisz_dzialania)
            {
                display.Clear();
                klawisz_dzialania = false;
            }

            display.AppendText("7");
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (klawisz_dzialania)
            {
                display.Clear();
                klawisz_dzialania = false;
            }
            display.AppendText("8");
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (klawisz_dzialania)
            {
                display.Clear();
                klawisz_dzialania = false;
            }
            display.AppendText("9");
        }


        private void equal_Click(object sender, EventArgs e)
        {
            druga_liczba = Int32.Parse(display.Text);

            

            switch (dzialanie)
            {
                case 0:
                    display.Text = (pierwsza_liczba + druga_liczba).ToString();
                    break;
                case 1:
                    display.Text = (pierwsza_liczba - druga_liczba).ToString();
                    break;
                case 2:
                    display.Text = (pierwsza_liczba * druga_liczba).ToString();
                    break;
                case 3:
                    display.Text = ((double)(pierwsza_liczba) / (double)(druga_liczba)).ToString();
                    break;
            }

            klawisz_dzialania = true;

        }

        private void plus_Click(object sender, EventArgs e)
        {
            pierwsza_liczba = Int32.Parse(display.Text);
            klawisz_dzialania = true;
            dzialanie = 0;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            pierwsza_liczba = Int32.Parse(display.Text);
            klawisz_dzialania = true;
            dzialanie = 1;
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            pierwsza_liczba = Int32.Parse(display.Text);
            klawisz_dzialania = true;
            dzialanie = 2;
        }

        private void division_Click(object sender, EventArgs e)
        {
            pierwsza_liczba = Int32.Parse(display.Text);
            klawisz_dzialania = true;
            dzialanie = 3;
        }
    }
}
