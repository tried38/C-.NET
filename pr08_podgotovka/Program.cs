using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr08
{
    internal class Program
    {
        //Написать функцию int DecToOct(A), целого типа, 
        //для выполнения перевода целого трехзначного числа А из десятичной системы счисления в восьмеричную систему счисления.
        static string DecToOct(int A)
        {
            if (A < 100 || A > 999)
            {
                return Convert.ToString(A, 8);
            }
            else
            {
                return "Число не подходит под условие (100 <= A < 999)";
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A:");
            int A = Convert.ToInt32(Console.ReadLine());

            // Проверка ввода
            if (int.TryParse(Console.ReadLine(), out A))
            {
                string result = DecToOct(A);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            }
        }

    }
}
