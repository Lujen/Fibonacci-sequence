using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciąg_Fibonacciego
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void fib(long n)
        {
            long a = 0, b = 1, c = 0;
            if (n == 1 || n == 2)
            {
                textBox1.Text = "1";
            }
            else if (n > 2)
            {
                for (long i = 0; i < n - 1; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                textBox1.Text = b.ToString();
            }
        }
            private void button1_Click(object sender, EventArgs e)
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Podaj liczbę ciągu do obliczenia.");
                }
                else
                {
                    long liczba = long.Parse(textBox2.Text);
                    if (liczba == 1)
                    {
                        MessageBox.Show("Nie można liczyć dla mniejszych elementów ciagu Fibonacciego.");
                    }
                    else if (liczba < 1)
                    {
                        MessageBox.Show("Błędna liczba");
                    }
                    else
                    {
                        fib(liczba - 1);
                        textBox2.Text = (liczba + -1).ToString();
                    }
                    
                }
            }
                

            private void button2_Click(object sender, EventArgs e)
            {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Podaj liczbę ciągu do obliczenia.");
            }
            else
            {
                long liczba = long.Parse(textBox2.Text);
                if (liczba < 1)
                {
                    MessageBox.Show("Błędna liczba");
                    textBox1.Clear();
                }
                else
                {
                    fib(liczba + 1);
                    textBox2.Text = (liczba + 1).ToString();
                }
            }
                
            }

            private void button3_Click(object sender, EventArgs e)
            {
                if(textBox2.Text=="")
                {
                    MessageBox.Show("Podaj liczbę ciągu do obliczenia.");
                }
                else
                {
                    long liczba = long.Parse(textBox2.Text);
                    if (liczba < 1)
                    {
                        MessageBox.Show("Błędna liczba.");
                        textBox1.Clear();
                    }
                    else
                        fib(liczba);
                }
            }
            private void button4_Click(object sender, EventArgs e)
            {
                textBox1.Clear();
                textBox2.Clear();
            }
            private void label1_Click(object sender, EventArgs e)
            {

            }
            private void label2_Click(object sender, EventArgs e)
            {

            }
            private void label3_Click(object sender, EventArgs e)
            {

            }
            private void label4_Click(object sender, EventArgs e)
            {

            }
            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }
            private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }

        
    }
    }

