using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sdkgnsjkdhngsj
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

                // Подсчет количества нечетных элементов на нечетных позициях
                int tempCount = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 1 && i % 2 == 1)
                    {
                        tempCount++;
                    }
                }

                // Создание конечного массива на основе подсчета
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
                                writer2.WriteLine(endarray[i]); // выводим найденные элементы
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
        }
    }
}
