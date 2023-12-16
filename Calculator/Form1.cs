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

        double Number1 = 0;
        double Number2 = 0;
        double Result = 0;
        string opperand;

        StringBuilder Number = new StringBuilder();
        StringBuilder screen = new StringBuilder();


        void Cal(double a,double b, string op)
        {
            if(opperand == " + ")
            {
                Number2 = Convert.ToDouble(Number.ToString());
                Result = Number1 + Number2;
                screen.Clear();
                screen.Append($"{Number1} + {Number2} = {Result}");
                screentxtbox.Text = screen.ToString();
            }
            else if(opperand == " - ")
            {
                Number2 = Convert.ToDouble(Number.ToString());
                Result = Number1 - Number2;
                screen.Clear();
                screen.Append($"{Number1} - {Number2} = {Result}");
                screentxtbox.Text = screen.ToString();
            }
            else if( opperand == " * ") 
            {
                Number2 = Convert.ToDouble(Number.ToString());
                Result = Number1 * Number2;
                screen.Clear();
                screen.Append($"{Number1} * {Number2} = {Result}");
                screentxtbox.Text = screen.ToString();
            }
            else if (opperand == " / ")
            {
                if(Number1 == 0)
                {
                    screentxtbox.Text = "ERROR!";

                }
                else if(Number2 == 0)
                {
                    screentxtbox.Text = "ERROR!";
                }
                else
                {
                    Number2 = Convert.ToDouble(Number.ToString());
                    Result = Number1 / Number2;
                    screen.Clear();
                    screen.Append($"{Number1} / {Number2} = {Result}");
                    screentxtbox.Text = screen.ToString();
                }
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            Number2 = Convert.ToDouble(Number.ToString());
            Cal(Number1,Number2,opperand);
            screen.Clear();
            Number.Clear();
            Number1 = 0;
            Number2 = 0;
            Result = 0;
            opperand = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string Nine = "8";
            screen.Append("8");
            Number.Append(Nine);
            screentxtbox.Text = screen.ToString();
        }

        private void minusbtn_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(Number.ToString());
            string Minus = " - ";
            screen.Append(Minus);
            opperand = Minus;
            screentxtbox.Text = screen.ToString();
            Number.Clear();
        }

        private void plusbtn_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(Number.ToString());
            string plus = " + ";
            screen.Append(plus);
            opperand = plus;
            screentxtbox.Text = screen.ToString();
            Number.Clear();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Number.Clear();
            Result = 0;
            Number1 = 0;
            Number2 = 0;
            screentxtbox = null;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            string Nine = "9";
            screen.Append("9");
            Number.Append(Nine);
            screentxtbox.Text = screen.ToString();
        }

        private void num6_Click(object sender, EventArgs e)
        {
            string Six = "6";
            screen.Append("6");
            Number.Append(Six);
            screentxtbox.Text = screen.ToString();

        }

        private void num3_Click(object sender, EventArgs e)
        {
            string Three = "3";
            screen.Append("3");
            Number.Append(Three);
            screentxtbox.Text = screen.ToString();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string Zero = "0";
            screen.Append("0");
            Number.Append(Zero);
            screentxtbox.Text = screen.ToString();

        }

        private void num5_Click(object sender, EventArgs e)
        {
            string Five = "5";
            screen.Append("5");
            Number.Append(Five);
            screentxtbox.Text = screen.ToString();

        }

        private void num2_Click(object sender, EventArgs e)
        {
            string Two = "2";
            screen.Append("2");
            Number.Append(Two);
            screentxtbox.Text = screen.ToString();

        }

        private void commabtn_Click(object sender, EventArgs e)
        {
            string Comma = ",";
            screen.Append(",");
            screentxtbox.Text = screen.ToString();
            Number.Append(Comma);
        }

        private void num7_Click(object sender, EventArgs e)
        {
            string Seven = "7";
            screen.Append("7");
            Number.Append(Seven);
            screentxtbox.Text = screen.ToString();


        }

        private void num4_Click(object sender, EventArgs e)
        {
            string Four = "4";
            screen.Append("4");
            Number.Append(Four);
            screentxtbox.Text = screen.ToString();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            string One = "1";
            screen.Append("1");
            Number.Append(One);
            screentxtbox.Text = screen.ToString();
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(Number.ToString());
            string Multi = " * ";
            screen.Append(Multi);
            opperand = Multi;
            screentxtbox.Text = screen.ToString();
            Number.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            screen.Clear();
            Number.Clear();
            Number1 = 0;
            Number2 = 0;
            Result = 0;
            opperand = "";
            screentxtbox.Text = "";
            
        }

        private void Div_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(Number.ToString());
            string Div = " / ";
            opperand = Div;
            screen.Append(Div);
            screentxtbox.Text = screen.ToString();
            Number.Clear();
        }
    }
}
