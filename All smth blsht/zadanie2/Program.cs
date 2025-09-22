using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            Console.WriteLine("Введите N");
            N = Convert.ToInt32(Console.ReadLine());
            double proizvedenie = 1;
            string primer = "";
            if (N < 0)
            {
                Console.WriteLine("Число не подходит под условие задачи");
            }
            else
            {
                if (N % 2 == 1)
                {
                    for (int i = 1; i <= N; i+=2)
                    {
                        proizvedenie *= i;
                        primer += i + (i < N ? "*" : "");
                    }
                }
                if (N % 2 == 0)
                {
                    for (int i = 2; i <= N; i+=2)
                    {
                        proizvedenie *= i;
                        primer += i + (i < N ? "*" : "");
                    }
                }
            }
            Console.WriteLine($"Произведение до числа {N} = {primer} = {proizvedenie}");
        }
    }
}

