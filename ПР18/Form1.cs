using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Zadanie 1
        #region Zadanie1
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBox1.Text);
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;

            if (N > 0 && N > 999 && N < 10000)
            {
                n1 = (N / 1000) % 10;
                n2 = (N / 100) % 10;
                n3 = (N / 10) % 10;
                n4 = N % 10;

                if (n1 == n2 && n2 == n3 && n3 == n4)
                {
                    textBox2.Text = "true";
                }
                else
                {
                    textBox2.Text = "false";
                }
            }
            else
            {
                textBox2.Text = "Число не подходит под условие";
            }
        }
        #endregion

        //Zadanie 2
        #region Zadanie2
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int X = Convert.ToInt32(textBox3.Text);
            int x1 = 0;
            int x2 = 0;
            int x3 = 0;
            int x4 = 0;

            if (X >= 100 && X <= 999)
            {
                x1 = (X / 100) % 10;
                x2 = (X / 10) % 10;
                x3 = X % 10;

                x4 = (x2 * 100) + (x3 * 10) + x1;
                textBox4.Text = Convert.ToString(x4);
            }
            else
            {
                textBox4.Text = "Число не подходит под условие";
            }
        }
        #endregion

        #region Zadanie3
        private void button7_Click(object sender, EventArgs e)
        {
            string input = textBox5.Text;
            if (input.Length != 4)
            {
                textBox6.Text = "Должно быть 4 цифры!";
                return;
            }

            int number;
            try
            {
                number = int.Parse(input); // Пробуем преобразовать
            }
            catch
            {
                textBox6.Text = "Введите только цифры!";
                return;
            }

            // Проверка палиндрома через математику
            if ((number / 1000 == number % 10) && ((number / 100) % 10 == (number / 10) % 10))
            {
                textBox6.Text = "Палиндром!";
            }
            else
            {
                textBox6.Text = "Не палиндром";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox6.Text = "";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region smth
        private void tabPage2_Click(object sender, EventArgs e)
        { }
        private void tabPage1_Click(object sender, EventArgs e)
        { }
        private void tabPage3_Click(object sender, EventArgs e)
        { }
        private void label1_Click(object sender, EventArgs e)
        { }
        private void label2_Click(object sender, EventArgs e)
        { }
        private void label3_Click(object sender, EventArgs e)
        { }
        private void label8_Click(object sender, EventArgs e)
        { }


        #endregion

    }
}
