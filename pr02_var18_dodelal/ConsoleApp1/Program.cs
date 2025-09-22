using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadanie 1
            int x = 0;
            int y = 0;
            try
            {
            //Ввод данных
            Console.WriteLine("Vvedite x: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vvedite y: ");
            y = Convert.ToInt32(Console.ReadLine());

                //проверка истенности высказывания (X и Y являются координатами точки, лежащей во второй координатной четверти)
                if (x < 0 && y > 0)
                {
                    Console.WriteLine("Точка находится во второй четверти");
                }
                else
                {
                    Console.WriteLine("Точка не находится во второй четверти");
                }
            //проверка на Exceptions
            }
            catch (System.FormatException exception)
            {
                Console.WriteLine(exception.Message.ToString());
            }
            catch (System.OverflowException exception1)
            {
                Console.WriteLine(exception1.Message.ToString());
            }

            //zadanie 2
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            try
            {
                //Ввод данных
                Console.WriteLine("Vvedite a: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Vvedite b: ");
                b = Convert.ToInt32(Console.ReadLine());
                //проверка (a и b два ненулевых положительных целых числа)
                if (a <= 0 | b <= 0)
                {
                    Console.WriteLine("One of the numbers = 0");
                }
                else
                {
                    //Нахождение суммы разности, произведения и частного.
                    c = (a + b);
                    d = (a - b);
                    e = (a * b);
                    f = (a / b);
                    //Вывод на экран
                    Console.WriteLine("summa = {0}", c);
                    Console.WriteLine("raznost = {0}", d);
                    Console.WriteLine("proizvidenie = {0}", e);
                    Console.WriteLine("chastnoe = {0}", f);
                }
            }
            //проверка на Exceptions
            catch (System.FormatException exception)
            {
                Console.WriteLine(exception.Message.ToString());
            }
            catch (System.OverflowException exception1)
            {
                Console.WriteLine(exception1.Message.ToString());
            }

            //zadanie 3
            
            int N = 0;
            int N1 = 0;
            int N2 = 0;
            int N3 = 0;
            int N4 = 0;
            try
            {
                //Ввод данных
                Console.WriteLine("Vvedite N: ");
                N = Convert.ToInt32(Console.ReadLine());
                //Проверка числа подходящее под условие: Дано четырехзначное целое положительное число N (N>0)
                if (!(N <= 1000 && N >= 9999))
                {
                    Console.WriteLine("Число N не подходит для условия задачи");
                }

                else
                {
                    // Вытаскиваем из числа по цифре 
                    N1 = N / 1000;
                    N2 = (N / 100) % 10;
                    N3 = (N / 10) % 10; 
                    N4 = N % 10;

                    //Проверка на  истинность высказывания: "Все цифры данного числа различны"
                    if (N1 != N2 && N1 != N3 && N1 != N4 && N2 != N3 && N2 != N4 && N3 != N4)
                    {
                        Console.WriteLine("Все цифры данного числа различны.");
                    }
                    else
                    {
                        Console.WriteLine("Некоторые цифры данного числа совпадают.");
                    }
                }
            }
            //проверка на Exceptions
            catch (System.FormatException exception)
            {
                Console.WriteLine(exception.Message.ToString());
            }
            catch (System.OverflowException exception1)
            {
                Console.WriteLine(exception1.Message.ToString());
            }

            //zadanie 4
            int numb = 0;
            int lastnum = 0;
            int newnum = 0;
            int plusnum = 0;
            try
            {
                //Ввод данных
                Console.WriteLine("Введите трёхзначное положительное число:");
                numb = Convert.ToInt32(Console.ReadLine());

                if (numb >= 100 && numb <= 999)
                {
                    //Вытаскиваем из числа последнюю цифру 
                    lastnum = numb % 10;
                    plusnum = numb / 10;
                    newnum = lastnum * 100 + plusnum;
                    Console.WriteLine("New number = {0}", newnum);
                }
                else
                {
                    Console.WriteLine("Число не подходит под условие задания.");
                }

            }
            //проверка на Exceptions
            catch (System.FormatException exception)
            {
                Console.WriteLine(exception.Message.ToString());
            }
            catch (System.OverflowException exception1)
            {
                Console.WriteLine(exception1.Message.ToString());
            }


            // zadanie 5

            // Предлагаем пользователю выбрать масть игральной карты.
            Console.WriteLine("1 - пики, 2 - трефы, 3 - бубны, 4 - червы.");
            Console.Write("Пожалуйста, сделайте свой выбор: ");

            // Принимаем ввод от пользователя.
            string gamecard = Console.ReadLine();

            // Запрашиваем достоинство карты
            Console.WriteLine("Введите достоинство карты (6 - 14):");
            int P = Convert.ToInt32(Console.ReadLine());

            // Переменная для хранения названия карты
            string cardName = "";

            // Определяем масть карты
            switch (gamecard)
            {
                case "1":
                    cardName += "пик";
                    break;
                case "2":
                    cardName += "треф";
                    break;
                case "3":
                    cardName += "бубен";
                    break;
                case "4":
                    cardName += "червей";
                    break;
                default:
                    Console.WriteLine("Ошибка: некорректный ввод масти.");
                    return;
            }

            // Определяем достоинство карты
            if (P >= 6 && P <= 10)
            {
                cardName = P.ToString() + " " + cardName;
            }
            else
            {
                switch (P)
                {
                    case 11:
                        cardName = "валет " + cardName;
                        break;
                    case 12:
                        cardName = "дама " + cardName;
                        break;
                    case 13:
                        cardName = "король " + cardName;
                        break;
                    case 14:
                        cardName = "туз " + cardName;
                        break;
                    default:
                        Console.WriteLine("Ошибка: некорректное достоинство карты.");
                        return;
                }
            }

            // Выводим название карты
            Console.WriteLine("Вы выбрали: " + cardName);
            Console.ReadKey();


        }
        }
    }
