using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace PR21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string result1 = "";
        private string result2 = "";
        private string result3 = "";
        private string result4 = "";
        private string result5 = "";
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static double TriangleS(double a)
        {
            return (a * a * Math.Sqrt(3)) / 4;
        }
        private int FindThird(int a, int b, int c, int d, int t, int first, int second)
        {
            int third = int.MinValue;

            if (a != first && a != second && a > third) third = a;
            if (b != first && b != second && b > third) third = b;
            if (c != first && c != second && c > third) third = c;
            if (d != first && d != second && d > third) third = d;
            if (t != first && t != second && t > third) third = t;

            return third;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Zadanie 1
                int N = Convert.ToInt32(textBox1.Text);
                if (N >= 1000 && N <= 9999)
                {
                    int N1 = N / 1000;
                    int N2 = (N / 100) % 10;
                    int N3 = (N / 10) % 10;
                    int N4 = N % 10;

                    if (N1 == N4 && N2 == N3)
                    {
                        label2.Text = "Данное число N читается одинаково слева направо и справа налево";
                        result1 = $"Данное число {N} читается одинаково слева направо и справа налево";
                    }
                    else
                    {
                        label2.Text = $"Данное число {N} не читается одинаково слева направо и справа налево";
                    }
                }
                else
                {
                    label2.Text = "Число не подходит под условие (должно быть 4-значным)";
                    result1 = "Число не подходит под условие (должно быть 4-значным)";
                }
                //Zadanie 2
                int a = Convert.ToInt32(textBox2.Text);
                int b = Convert.ToInt32(textBox3.Text);
                int c = Convert.ToInt32(textBox4.Text);
                int d = Convert.ToInt32(textBox5.Text);
                int t = Convert.ToInt32(textBox6.Text);
                int first, second, third;
                if (a == b || a == c || a == d || a == t ||
                    b == c || b == d || b == t ||
                    c == d || c == t ||
                    d == t)
                {
                    label4.Text = "Числа должны быть различными";
                    result2 = "Числа должны быть различными";
                }
                else
                {
                    if (a == 0 || b == 0 || c == 0 || d == 0 || t == 0)
                    {
                        label4.Text = "Одно из чисел не подходит под условие";
                        result2 = "Одно из чисел не подходит под условие";
                    }
                    else
                    {
                        first = Math.Max(Math.Max(Math.Max(a, b), Math.Max(c, d)), t);

                        if (a == first)
                            second = Math.Max(Math.Max(Math.Max(int.MinValue, b), Math.Max(c, d)), t);
                        else if (b == first)
                            second = Math.Max(Math.Max(Math.Max(a, int.MinValue), Math.Max(c, d)), t);
                        else if (c == first)
                            second = Math.Max(Math.Max(Math.Max(a, b), Math.Max(int.MinValue, d)), t);
                        else if (d == first)
                            second = Math.Max(Math.Max(Math.Max(a, b), Math.Max(c, int.MinValue)), t);
                        else
                            second = Math.Max(Math.Max(Math.Max(a, b), Math.Max(c, d)), int.MinValue);

                        third = FindThird(a, b, c, d, t, first, second);
                        int product = first * second * third;
                        label4.Text = product.ToString();
                        result2 = $"Произведение трех наибольших чисел из пяти = {product}";
                    }
                }
                    
                // Zadanie 3
                double a1 = Convert.ToDouble(textBox2.Text);
                double a2 = Convert.ToDouble(textBox2.Text);
                double a3 = Convert.ToDouble(textBox2.Text);
                double area1 = TriangleS(a1);
                double area2 = TriangleS(a2);
                double area3 = TriangleS(a3);

                label6.Text = $"Area 1st Triangle: {area1}";
                label7.Text = $"Area 2nd Triangle: {area2}";
                label8.Text = $"Area 3rd Triangle: {area3}";
                result3 = $"Площадь первого равностороннего треугольника со стороной {a1} = {area1}";
                result4 = $"Площадь второго равностороннего треугольника со стороной {a2} = {area2}";
                result5 = $"Площадь третьего равностороннего треугольника со стороной {a3} = {area3}";

                //создаем новый документ Word
                Word.Application wdApp = new Word.Application();
                Word.Document wdDoc = null;
                Object wdMiss = System.Reflection.Missing.Value;

                wdDoc = wdApp.Documents.Add(ref wdMiss, ref wdMiss, ref wdMiss, ref wdMiss);

                wdDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientPortrait;

                wdDoc.PageSetup.TopMargin = wdApp.InchesToPoints(0.60f);
                wdDoc.PageSetup.BottomMargin = wdApp.InchesToPoints(0.60f);
                wdDoc.PageSetup.LeftMargin = wdApp.InchesToPoints(0.80f);
                wdDoc.PageSetup.RightMargin = wdApp.InchesToPoints(0.59f);

                wdApp.Visible = true;

                // Заголовок
                Word.Paragraph oPara7 = wdDoc.Content.Paragraphs.Add(ref wdMiss);
                oPara7.Range.Text = "МДК.01.01 Разработка программных модулей";
                oPara7.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                oPara7.Range.Font.Size = 18;
                oPara7.Range.Font.Bold = 1;
                oPara7.Range.InsertParagraphAfter();
                // Информация о студенте
                Word.Paragraph oPara8 = wdDoc.Content.Paragraphs.Add(ref wdMiss);
                oPara8.Range.Text = "ПР21 «Программное создание документов MS Word в языке С#»\r\nВыполнил Малетин Алексей, студент группы ИС-23Б\r\n";
                oPara8.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                oPara8.Range.Font.Size = 16;
                oPara8.Range.Font.Bold = 0;
                oPara8.Range.InsertParagraphAfter();
                // Задание 1
                Word.Paragraph oPara1 = wdDoc.Content.Paragraphs.Add(ref wdMiss);
                oPara1.Range.Text = $"Задание 1:\r\n{result1}\r\n";
                oPara1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                oPara1.Range.Font.Size = 16;
                oPara1.Range.Font.Bold = 0;
                oPara1.Range.InsertParagraphAfter();
                // Задание 2
                Word.Paragraph oPara2 = wdDoc.Content.Paragraphs.Add(ref wdMiss);
                oPara2.Range.Text = $"Задание 2:\r\n{result2}\r\n";
                oPara2.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                oPara2.Range.Font.Size = 16;
                oPara2.Range.Font.Bold = 0;
                oPara2.Range.InsertParagraphAfter();
                // Задание3
                Word.Paragraph oPara3 = wdDoc.Content.Paragraphs.Add(ref wdMiss);
                oPara3.Range.Text = $"Задание 3:\r\n{result3}\r\n";
                oPara3.Range.Text = $"\r\n{result4}\r\n";
                oPara3.Range.Text = $"\r\n{result5}\r\n";
                oPara3.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                oPara3.Range.Font.Size = 16;
                oPara3.Range.Font.Bold = 0;
                oPara3.Range.InsertParagraphAfter();

                // Сохранение документа
                try
                {
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filename = System.IO.Path.Combine(desktopPath, "pr21.doc");

                    wdDoc.SaveAs(filename);
                    label7.Text = "Документ сохранен на рабочем столе";
                }
                catch (Exception y)
                {
                    label7.Text = "Ошибка сохранения документа";
                    Console.WriteLine("Ошибка сохранения документа", y.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
