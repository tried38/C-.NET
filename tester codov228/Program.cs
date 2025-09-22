using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tester_codov228
{
    namespace tester_codov228
    {
        internal class Program
        {
            static void Main(string[] args)
            {

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
}

