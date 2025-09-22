using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr08
{
    internal class Program
    {
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
        static string TimeToDay(int H, int M, int S)
        {
            int intotalday = ((H * 3600) + (M * 60) + S) / 86400;
            return intotalday.ToString();
        }
        static void CoordinateQuarter(int x, int y)
        {
            if (x > 0 || y < 0)
            {
                Console.WriteLine("Точка с координатами x = {0} и y = {1} лежит в четвертой координатной четверти", x, y);
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Не подходит под условие (числа x, y - ненулевые)");
            }
            else
            {
                Console.WriteLine("Точка с координатами x = {0} и y = {1} НЕ лежит в четвертой координатной четверти", x, y);
            }
        }
        static void Countznaki(string stoka)
        {
            int count = 0;
            char[] chars = stoka.ToCharArray();
            if (chars.Length < 40)
            {
                Console.WriteLine("Минимальный размер строки (массив символов) - не менее 40 символов.");
            }
            else
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] == '.')
                        count++;
                    else if (chars[i] == ',')
                        count++;
                    else if (chars[i] == ':')
                        count++;
                    else if (chars[i] == ';')
                        count++;
                    else if (chars[i] == '!')
                        count++;
                    else if (chars[i] == '?')
                        count++;
                    else continue;
                }
            }
            Console.WriteLine("оличество содержащихся в строке знаков препинания (точка, запятая, двоеточие, точка с запятой, восклицательный знак, вопросительный знак)" + count);
        }
        static void Main(string[] args)
        {
        m1:
            try
            {
                Console.Write("Пожалуйста, сделайте свой выбор (1 - 1-ое задание; " +
                "2 - 2-ое задание; 3 - 3-е задание; 4 - 4-ое задание; 5 - 5-ое задание): ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        //Даны ненулевые числа x, y. Проверить истинность высказывания:
                        //«Точка с координатами (x, y) лежит в четвертой координатной четверти».
                        Console.WriteLine("Введите число x:");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите число y:");
                        int y = Convert.ToInt32(Console.ReadLine());
                        CoordinateQuarter(x, y);
                        goto m1;
                    case 2:

                    case 3:
                        //Вводится строка-предложение.Длина строки может быть разной.
                        //Подсчитать количество содержащихся в строке знаков препинания
                        //(точка, запятая, двоеточие, точка с запятой, восклицательный знак, вопросительный знак).
                        Console.WriteLine("Введите строку (в которой могут содержаться знаки препинаиня");
                        string inputstorka = Console.ReadLine().ToLower();
                        Countznaki(inputstorka);
                        goto m1;
                    case 4:
                        Console.WriteLine("Введите число H - часы:");
                        int H = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите число M - минуты:");
                        int M = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите число S - секунды:");
                        int S = Convert.ToInt32(Console.ReadLine());

                        string days = TimeToDay(H, M, S);
                        Console.WriteLine("Прошло дней " + days);
                        goto m1;

                    case 5:
                        //Написать функцию int DecToOct(A), целого типа, 
                        //для выполнения перевода целого трехзначного числа А из десятичной системы счисления в восьмеричную систему счисления.
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
                        goto m1;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        goto m1;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto m1;
            }
        }
    }
}
