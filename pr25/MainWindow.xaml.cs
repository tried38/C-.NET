using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using pr25;

namespace pr25
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(textBox1.Text);
                if (A > 0)
                {
                    if (A % 2 == 0 && A > 99 && A < 1000)
                    {
                        label2.Content = "Данное целое положительное число является четным трехзначным числом";
                    }
                    else
                    {
                        label2.Content = "Данное целое положительное число НЕ является четным трехзначным числом";
                    }
                }
                else
                {
                    label2.Content = "Данное число не подходит под условие";
                }
            }
            catch(Exception ex) 
            { 
                label2.Content = ex; 
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int N = Convert.ToInt32(textBox2.Text);
                if (N > 0 && N >999 && N<10000)
                {
                    int N1 = N / 1000;
                    int N2 = (N / 100) % 10;
                    int N3 = (N / 10) % 10;
                    int N4 = N % 10;
                    int N5 = N1 + N2 + N3 + N4;
                    int N6 = N1 * N3;
                    int N7 = N5 - N6;
                    label4.Content = Convert.ToString(N7);
                }
                else
                {
                    label4.Content = "Данное число не подходит под условие";
                }
            }
            catch (Exception ex)
            {
                label4.Content = ex;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                Class1 Class1 = new Class1();
                int K = Convert.ToInt32(textBox3.Text);

                if (K > 0)
                {
                    bool result = Class1.IsSquare(K);

                    if (result)
                    {
                        label6.Content = "True";
                    }
                    else
                    {
                        label6.Content = "False";
                    }
                }
                else
                {
                    label6.Content = "Число должно быть положительным";
                }
            }
            catch (Exception ex)
            {
                label6.Content = ex;
            }
        }
    }
}
