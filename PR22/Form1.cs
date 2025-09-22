using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using maletin;

namespace PR22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 math = new Class1();
            //zad1
            int positive = math.positivenum(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            label2.Text = Convert.ToString(positive);
            //zad2
            int differ = math.difference(Convert.ToInt32(textBox4.Text));
            label4.Text = Convert.ToString(differ);
            //zad3
            int min3 = math.Min3(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text));
            label6.Text = Convert.ToString(min3);
        }
    }
}
