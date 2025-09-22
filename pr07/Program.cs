using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace pr07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа № 07");
            Console.WriteLine("Файловый ввод/вывод в языке С#");
            Console.WriteLine("Вариант 18");
            Console.WriteLine("Выполнил Малетин Алексей");
            Console.WriteLine(new string('-', 70));
            #region Задание1
            try
            {
                //Даны три целых числа: A, B, C. Проверить истинность высказывания: «Число B находится между числами A и C».
                int A = 0;
                int B = 0;
                int C = 0;
                using (StreamReader reader = File.OpenText("Input1.txt"))
                {
                    if (!reader.EndOfStream)
                    {
                        A = Convert.ToInt32(reader.ReadLine());
                    } 
                    if (!reader.EndOfStream)
                    {
                        B = Convert.ToInt32(reader.ReadLine());
                    }
                    if (!reader.EndOfStream)
                    {
                        C = Convert.ToInt32(reader.ReadLine());
                    }
                    Console.WriteLine(A);
                    Console.WriteLine(B);
                    Console.WriteLine(C);
                    using (StreamWriter writer = File.CreateText("Output1.txt"))
                    {
                        if (B > A && B < C)
                        {
                            writer.WriteLine("Число B находится между числами A и C");
                        }
                        else
                        {
                            writer.WriteLine("Число B не находится между числами A и C");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Измените значения в файле!");
            }
            #endregion

            #region Задание2
            try
            {
                //Даны два целых положительных числа A и B (A < B). Найти произведение всех чисел расположенных между этими числами A и B.
                int A1 = 0;
                int B1 = 0;
                int proizvedenie = 1;
                using (StreamReader reader1 = File.OpenText("Input2.txt"))
                {
                    if (!reader1.EndOfStream)
                    {
                        A1 = Convert.ToInt32(reader1.ReadLine());
                    }
                    if (!reader1.EndOfStream)
                    {
                        B1 = Convert.ToInt32(reader1.ReadLine());
                    }
                    Console.WriteLine(A1);
                    Console.WriteLine(B1);
                    using (StreamWriter writer1 = File.CreateText("Output2.txt"))
                    {
                        if (A1 < B1)
                        {
                            for (int i = A1 + 1; i < B1; i++)
                            {
                                proizvedenie *= i;
                            }
                            writer1.WriteLine(proizvedenie);
                        }
                        else
                        {
                            writer1.WriteLine("Число A1 > числа B1");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Измените значения в файле!");
            }
            #endregion

            #region Задание3
            //Дан целочисленный массив, состоящий из N элементов (N > 0). Найти и вывести количество элементов, расположенных после самого последнего максимального элемента.

            try
            {
                int[] array;
                int lastMaxIndex = -1;
                using (StreamReader reader2 = File.OpenText("Input3.txt"))
                {
                    string input = reader2.ReadLine();
                    array = Array.ConvertAll(input.Split(','), int.Parse);
                }
                using (StreamWriter writer2 = File.CreateText("Output3.txt"))
                {
                    if (array.Length < 25)
                    {
                        writer2.WriteLine("Массив меньше 25 символов!");
                    }
                    else
                    {
                        int maxElement = int.MinValue;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] > maxElement)
                            {
                                maxElement = array[i];
                                lastMaxIndex = i; // Обновляем индекс максимального элемента
                            }
                            else if (array[i] == maxElement)
                            {
                                lastMaxIndex = i; // Обновляем индекс, если встречаем второй максимум
                            }
                        }
                    }
                }
                    // Количество элементов после последнего максимального
                    int countAfterLastMax = array.Length - lastMaxIndex - 1;
                    Console.WriteLine($"Количество элементов после последнего максимального элемента: {countAfterLastMax}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Измените значения в файле!");
            }
            #endregion

            #region Задание4
            //Вводится строка, изображающая целочисленное арифметическое выражение вида «число_число_число_число», 
            //где на месте знака операции «_» находится символ «*» -умножение или «/» -деление, а на месте "число" 
            //находится целочисленное значение(от 1 до 99).Например, «41 * 7 / 29 * 5». 
            //Вывести значение данного выражения(как целое или вещественное значение).
            try
            {
                string filePath = "Input4.txt";
                string line = string.Empty;
                double result = 1;
                string numberBuffer = string.Empty;
                char operation = '*';
                using (StreamReader reader = new StreamReader(filePath))
                {
                    line = reader.ReadLine();
                }
                Console.WriteLine($"Считанная строка: {line}");
                for (int i = 0; i < line.Length; i++)
                {
                    char currentChar = line[i];
                    if (char.IsDigit(currentChar))
                    {
                        numberBuffer += currentChar;
                    }
                    else if (currentChar == '*' || currentChar == '/')
                    {
                        if (numberBuffer.Length > 0)
                        {
                            double number = double.Parse(numberBuffer);
                            if (operation == '*')
                            {
                                result *= number;
                            }
                            else if (operation == '/')
                            {
                                result /= number;
                            }
                            numberBuffer = string.Empty;
                        }
                        operation = currentChar;
                    }

                    else if (currentChar == '*' || currentChar == '/')
                    {
                        operation = currentChar;
                    }
                    }
                    if (numberBuffer.Length > 0)
                    {
                        double number = double.Parse(numberBuffer);
                        if (operation == '*')
                        {
                            result *= number;
                        }
                    else if (operation == '/')
                    {
                        result /= number;
                    }
                }
                using (StreamWriter writer = new StreamWriter("Output4.txt"))
                {
                    writer.WriteLine(result);
                }
                Console.WriteLine("Результат: " + result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Измените значения в файле!");
            }
            #endregion
        }
    }
}
