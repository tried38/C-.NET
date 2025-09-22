using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;

namespace PR09
{

    class Program
    {
        static double TriangleP(double a)
        {
            return 3 * a;
        }
        static int CountDigitsEven(int K)
        {
            int countchetnie = 0;
            if (K < 0)
            {
                Console.WriteLine("Число должно быть положитеьлное");
            }
            else
            {
                while (K != 0)
                {
                    int chislotyt = K % 10;
                    if (chislotyt % 2 == 0)
                    {
                        countchetnie++;
                    }
                    K /= 10;
                }
            }
            return countchetnie;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа № 09");
            Console.WriteLine("Коллекции в C#");
            Console.WriteLine("Вариант 18");
            Console.WriteLine("Выполнил Малетин Алексей");
            Console.WriteLine(new string('-', 70));
        #region Задание1
        m1:
            try
            {
                //Проверить истинность высказывания: "Квадратное уравнение A·x2 + B·x + C = 0 с данными коэффициентами A (A не равно 0), B, C имеет ровно два вещественных корня".
                Console.WriteLine("Zadanie 1");
                Console.WriteLine("Проверить истинность высказывания: \"Квадратное уравнение A·x2 + B·x + C = 0 с данными коэффициентами A (A не равно 0), B, C имеет ровно два вещественных корня\".");
                double A = 0;
                double B = 0;
                double C = 0;
                using (StreamReader reader1 = File.OpenText("input1.txt"))
                {
                    if (!reader1.EndOfStream)
                    {
                        A = Convert.ToDouble(reader1.ReadLine());
                    }
                    if (!reader1.EndOfStream)
                    {
                        B = Convert.ToDouble(reader1.ReadLine());
                    }
                    if (!reader1.EndOfStream)
                    {
                        C = Convert.ToDouble(reader1.ReadLine());
                    }
                    double D = B * B - 4 * A * C;
                    using (StreamWriter writer1 = File.CreateText("output1.txt"))
                    {
                        if (A == 0)
                        {
                            Console.WriteLine("Programm work off");
                            writer1.WriteLine("A не равно 0");

                        }
                        else
                        {
                            if (D > 0)
                            {
                                Console.WriteLine("Programm work off");
                                writer1.WriteLine($"Уравнение с кофициентами {A}, {B} и {C} имеет ровно два вещественных корня");
                            }
                            else if (D == 0)
                            {
                                Console.WriteLine("Programm work off");
                                writer1.WriteLine($"Уравнение с кофициентами {A}, {B} и {C} имеет ровно одни вещественный корень");
                            }
                            else
                            {
                                writer1.WriteLine("Уравнение не имеет вещественных корней");
                                Console.WriteLine("Programm work off");
                            }

                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Измените значения в файле!");
            }
            Console.WriteLine(new string('-', 70));
            #endregion

        #region Задание2
            try
            {
                //Дан целочисленный массив, состоящий из N элементов (N > 0). Найти и вывести все элементы, которые являются нечетными и стоят на нечетных позициях.
                Console.WriteLine("Zadanie 2");
                Console.WriteLine("Дан целочисленный массив, состоящий из N элементов (N > 0). Найти и вывести все элементы, которые являются нечетными и стоят на нечетных позициях.");
                int[] array;
                using (StreamReader reader2 = File.OpenText("input2.txt"))
                {
                    string input = reader2.ReadLine();
                    array = Array.ConvertAll(input.Split(','), int.Parse);
                }
                var str = string.Join(" ", array);
                Console.WriteLine(str);
                int tempCount = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1 && i % 2 == 1)
                    {
                        tempCount++;
                    }
                }
                int[] endarray = new int[tempCount];
                int count = 0;
                using (StreamWriter writer2 = File.CreateText("output2.txt"))
                {
                    if (array.Length < 25)
                    {
                        writer2.WriteLine("Массив меньше 25 элементов!");
                    }
                    else
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 == 1 && i % 2 == 1)
                            {
                                endarray[count] = array[i];
                                count++;
                            }
                        }
                        if (count > 0)
                        {
                            writer2.WriteLine("Нечетные элементы на нечетных позициях:");
                            for (int i = 0; i < count; i++)
                            {
                                writer2.WriteLine(endarray[i]);
                            }
                        }
                        else
                        {
                            writer2.WriteLine("Нет нечетных элементов на нечетных позициях.");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Измените значения в файле!");
            }
            Console.WriteLine(new string('-', 70));
            #endregion

        #region Задание3
            Console.WriteLine("Zadanie 3");
            Console.WriteLine("Вводится строка, состоящая из слов, разделенных подчеркиваниями (одним или несколькими). Длина строки может быть разной. Найти и вывести все слова, начинающиеся на гласную букву.");
            string inputFilePath = "input3.txt";
            string outputFilePath = "output3.txt";
            string inputString = File.ReadAllText(inputFilePath);
            string[] words = inputString.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var wordsStartingWithVowel = words.Where(word => vowels.Contains(word[0]));
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (string word in wordsStartingWithVowel)
                {
                    writer.WriteLine(word);
                }
            }
            Console.WriteLine("Programm work off");
            Console.WriteLine(new string('-', 70));
            #endregion

        #region Задание4
            try
            {
                //Написать функцию int CountDigitsEven(K) целого типа, возвращающую количество четных цифр в целом положительном числе K (K > 0).
                Console.WriteLine("Zadanie 4");
                Console.WriteLine("Написать функцию int CountDigitsEven(K) целого типа, возвращающую количество четных цифр в целом положительном числе K (K > 0).");
                int K = 0;
                using (StreamReader reader4 = File.OpenText("input4.txt"))
                {
                    if (!reader4.EndOfStream)
                    {
                        K = Convert.ToInt32(reader4.ReadLine());
                    }
                }
                using (StreamWriter writer4 = File.CreateText("output4.txt"))
                {
                    {
                        Console.WriteLine("Programm work off");
                        writer4.WriteLine($"Количество четных цифр в целом положительном числе K = {CountDigitsEven(K)}");
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Измените значения в файле!");
            }
            Console.WriteLine(new string('-', 70));
            #endregion

        #region Задание5
            Console.WriteLine("Zadanie 5");
            Console.WriteLine("Написать функцию double TriangleP(a) вещественного типа, вычисляющую по стороне a равностороннего треугольника его периметр P = 3·a (параметр a является вещественным). С помощью этой процедуры найти периметры трех равносторонних треугольников с данными сторонами.");
            double side1 = 0;
            double side2 = 0;
            double side3 = 0;
            using (StreamReader reader5 = File.OpenText("input5.txt"))
            {
                if (!reader5.EndOfStream)
                {
                    side1 = Convert.ToDouble(reader5.ReadLine());
                }
                if (!reader5.EndOfStream)
                {
                    side2 = Convert.ToDouble(reader5.ReadLine());
                }
                if (!reader5.EndOfStream)
                {
                    side3 = Convert.ToDouble(reader5.ReadLine());
                }
            }
            double perimeter1 = TriangleP(side1);
            double perimeter2 = TriangleP(side2);
            double perimeter3 = TriangleP(side3);
            using (StreamWriter writer5 = File.CreateText("output5.txt"))
            {
                writer5.WriteLine($"Периметр первого треугольника: {perimeter1}");
                writer5.WriteLine($"Периметр второго треугольника: {perimeter2}");
                writer5.WriteLine($"Периметр третьего треугольника: {perimeter3}");
                Console.WriteLine("Programm work off");
            }
            Console.WriteLine(new string('-', 70));
            #endregion
            Console.ReadKey();
        }
    }
}
