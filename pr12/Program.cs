using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using var18;

namespace pr12
{
    internal class Program
    {
        static void Main(string[] args)
        {
        m:
            try
            {
                #region Zadanie1
                task01 task1 = new task01();
                Console.WriteLine("Vvdite N");
                int write_N = task1.GetN(Convert.ToInt32(Console.ReadLine()));
                if (write_N < 0)
                {
                    Console.WriteLine("Число не подходит под задание");
                    goto m;
                }
                else
                {
                    if (write_N < 100 || write_N > 999)
                    {
                        Console.WriteLine("Число не подходит под задание");
                        goto m;
                    }
                    else
                    {
                        int N_10 = write_N % 10;
                        int N_100 = write_N / 100;
                        if (N_10 == N_100)
                        {
                            Console.WriteLine($"Данное число {write_N} читается одинаково слева напрво и спарва налево");
                        }
                        else
                        {
                            Console.WriteLine($"Данное число {write_N} НЕ читается одинаково слева напрво и спарва налево");
                        }
                    }
                }
                #endregion
                Console.WriteLine(new string('-', 70));
                #region Zadanie2
                task02 task2 = new task02();
                Console.WriteLine("Vvdite Q");
                int write_Q = task2.GetQ(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Vvdite W");
                int write_W = task2.GetW(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Vvdite E");
                int write_E = task2.GetE(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Vvdite R");
                int write_R = task2.GetR(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Vvdite T");
                int write_T = task2.GetT(Convert.ToInt32(Console.ReadLine()));
                string result = $"{write_Q} {write_W} {write_E} {write_R} {write_T}";
                Console.WriteLine(result);
                if (write_Q <= 0 || write_W <= 0 || write_E <= 0 || write_R <=0 || write_T <= 0) 
                {
                    Console.WriteLine("Одно или несколько чисел не подходят под задание");
                    goto m;
                }
                else
                {
                    int min1 = Math.Min(Math.Min(Math.Min(write_Q, write_W), Math.Min(write_E, write_R)), write_T);
                    Console.WriteLine(min1);
                    int min2 = int.MaxValue;

                    if (write_Q != min1) min2 = Math.Min(min2, write_Q);
                    if (write_W != min1) min2 = Math.Min(min2, write_W);
                    if (write_E != min1) min2 = Math.Min(min2, write_E);
                    if (write_R != min1) min2 = Math.Min(min2, write_R);
                    if (write_T != min1) min2 = Math.Min(min2, write_T);
                    if (min2 == int.MaxValue)
                        min2 = min1;
                    int sum = min1 + min2;
                    Console.WriteLine($"Сумма двух наименьших: {sum}");
                }
                #endregion
                Console.WriteLine(new string('-', 70));
                #region Zadanie4
                task04 task4 = new task04();
                Console.WriteLine("Vvdite A");
                int write_A = task4.GetA(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Vvdite B");
                int write_B = task4.GetB(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Vvdite C");
                int write_C = task4.GetC(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Vvdite D");
                int write_D = task4.GetD(Convert.ToInt32(Console.ReadLine()));
                int max_chslo = Math.Max(Math.Max(write_A, write_B), Math.Max(write_C, write_D));
                Console.WriteLine($"Одно максимальное значение из 4-х аргументов: {max_chslo}");
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto m;
            }



        }
    }
}
