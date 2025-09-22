using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //public static bool IsPalindrome(int K)
        //{
        //    if (K < 1000 || K > 9999)
        //    {
        //        return false;
        //    }

        //    int firstDigit = K / 1000;        // Первая цифра
        //    int secondDigit = (K / 100) % 10; // Вторая цифра
        //    int thirdDigit = (K / 10) % 10;   // Третья цифра
        //    int fourthDigit = K % 10;         // Четвёртая цифра

        //    // Проверяем, является ли число палиндромом
        //    return (firstDigit == fourthDigit) && (secondDigit == thirdDigit);
        //}

        static void Main(string[] args)
        {
            //Console.Write("Введите четырёхзначное число: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //try
            //{
            //    bool result = IsPalindrome(number);
            //    if (result == true)
            //    {
            //        Console.WriteLine("Это палиндром!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Это НЕ палиндром!");
            //    }
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            Console.Write("Введите tрёхзначное число: ");
            int X = Convert.ToInt32(Console.ReadLine());
            int x1 = 0;
            int x2 = 0;
            int x3 = 0;
            int x4 = 0;

            if (X >= 100 && X <= 999)
            {
                x1 = (X / 100) % 10;
                x2 = (X / 10) % 10;
                x3 = X % 10;

                x4 = (x2 * 100) + (x3 * 10) + x1;
                Console.Write(x4);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
