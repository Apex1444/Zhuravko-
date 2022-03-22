using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace треугольлник
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int x = a + b;
            int y = a + c;
            int z = c + b;
            if (x > c && y > b && z > a)
                label4.Text=("Треугольлник реализуется");
            else
                label4.Text = ("Треугольлник не реализуется");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int x = a + b;
            int y = a + c;
            int z = c + b;
            if (x > c && y > b && z > a)
            {
                if (a == b && a == c && c == b)
                {
                    label5.Text = ("Треугольник равносторонний");
                    return;

                }
                if (a == b || a == c || b == c)
                {
                    label5.Text = ("Треугольлник равнобедренный");
                }
                else label5.Text = ("Треугольлник разносторонний");

                if ((c * c == a * a + b + b) || (b * b == a * a + c * c) || (c * c == a * a + b * b))
                { label6.Text = "Треугольник прямоугольный";  }
                if ((c * c < a * a + b * b)|| (b * b < a * a + c * c )|| (c * c < a * a + b *b))
                { label6.Text = "Треугольник остроугольный"; }
                            
                else { label6.Text = "Треугольник тупоугольный"; }
                
                float p = (a + b + c) / 2;
            double  s= (float) Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                s = (float)Math.Round(s, 2);
                label6.Text = Convert.ToString(s);
                label7.Text = Convert.ToString(p);

                
                    label6.Text = ("Площадь круга равна");
            }
            else { label4.Text=("Треугольлник не реализуется"); }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;

            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);

            float p = (a + b + c) / 2;
            double s = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            s = (float)Math.Round(s, 2);
            label6.Text = Convert.ToString(s);
            label7.Text = Convert.ToString(p);


            label6.Text = ("Площадь круга равна");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }




        



