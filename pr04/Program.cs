using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace pr04
{
    internal class Program
    {
        static void Main(string[] args)
        {
        m1:
            Console.WriteLine("zadanie 1");
            try
            {
                int a = 0;
                int b = 0;
                int c = 0;
                Console.WriteLine("Введите A");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите B");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите C");
                c = Convert.ToInt32(Console.ReadLine());
                //Тут проверка если введены все отрицательные числа
                if (a < 0 && b < 0 && c < 0)
                {
                    Console.WriteLine("Все числа отрицательные");
                }
                //Тут проверка если введены все положительные числа
                if (a > 0 && b > 0 && c > 0)
                {
                    Console.WriteLine("Все числа положительные");
                }
                //Тут проверка если хотя бы одно из чисел A, B, C положительное
                if (a > 0 && b < 0 && c < 0) 
                {
                    Console.WriteLine("Хотя бы одно из чисел A, B, C положительное");
                }
                if (a < 0 && b > 0 && c < 0) 
                {
                    Console.WriteLine("Хотя бы одно из чисел A, B, C положительное");
                }
                if (a < 0 && b < 0 && c > 0) 
                {
                    Console.WriteLine("Хотя бы одно из чисел A, B, C положительное");
                }
                //Тут проверка если два положительных
                if (a < 0 && b > 0 && c > 0)
                {
                    Console.WriteLine("Хотя бы одно из чисел A, B, C положительное");
                }
                if (a > 0 && b > 0 && c < 0)
                {
                    Console.WriteLine("Хотя бы одно из чисел A, B, C положительное");
                }
                if (a > 0 && b < 0 && c > 0)
                {
                    Console.WriteLine("Хотя бы одно из чисел A, B, C положительное");
                }
            }
            catch (System.FormatException exception)
            {
                Console.WriteLine(exception.Message.ToString());
                goto m1;
            }
            catch (System.OverflowException exception1)
            {
                Console.WriteLine(exception1.Message.ToString());
                goto m1;
            }

        m2:
            Console.WriteLine("zadanie 2");
            try
            {
                int N;
                Console.WriteLine("Введите колличество элементов в массиве");
                N = Convert.ToInt32(Console.ReadLine());
                if (N < 25)
                {
                    Console.WriteLine("Минимальный размер массива должен быть не менее 25 элементов.");
                    goto m2;
                }
                int[] m = new int[N];
                Console.Write("Пожалуйста, сделайте свой выбор (1 - авто массив; 2 - ручной массив): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                Random rand = new Random();

                switch (choice)
                {
                    case 1:
                        for (int i = 0; i < m.Length; i++)
                        {
                            m[i] = rand.Next(100);
                        }
                        break;

                    case 2:
                        for (int i = 0; i < m.Length; i++)
                        {
                            Console.WriteLine("Введите значение для элемента массива №" + i);
                            m[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        break;

                    default:
                        Console.WriteLine("Неверный выбор.");
                        goto m2;
                }
                // Сохраним исходный массив для вывода
                int[] originalArray = (int[])m.Clone();
                //Находим занчения max и min
                int maxIndex = Array.IndexOf(m, m.Max());
                int minIndex = Array.IndexOf(m, m.Min());
                //Меняем местами
                int temp = m[maxIndex];
                m[maxIndex] = m[minIndex];
                m[minIndex] = temp;
                //Выводим два массива вначале исходный массив, а строкой ниже полученный массив после замены.
                string originalResult = string.Join(", ", originalArray);
                string result = string.Join(", ", m);
                Console.WriteLine("Исходный массив: " + originalResult);
                Console.WriteLine("Массив после замены: " + result);
            }
            catch (System.FormatException exception)
            {
                Console.WriteLine(exception.Message.ToString());
                goto m2;
            }
            catch (System.OverflowException exception1)
            {
                Console.WriteLine(exception1.Message.ToString());
                goto m2;
            }
        m3:
            Console.WriteLine("zadanie 3");
            try
            {
                Console.WriteLine("Введите строку");
                string input = Console.ReadLine();
                int length = input.Length;
                Console.WriteLine(length);
                if (length < 40)
                {
                    Console.WriteLine("Минимальный размер строки (массив символов) - не менее 40 символов");
                    goto m3;
                }
                else
                {
                    //преобразовать строку в массив и вывести массив
                    int count = 0;
                    int sum = 0;

                    foreach (char ch in input)
                    {
                        if (char.IsDigit(ch)) // Проверяем, является ли символ цифрой
                        {
                            count++; // Увеличиваем счетчик
                            sum += (ch - '0'); // Добавляем значение цифры к сумме
                        }
                    }

                    Console.WriteLine($"Количество чисел в строке: {count}");
                    Console.WriteLine($"Сумма чисел: {sum}");

                }
            }
            catch (System.FormatException exception)
            {
                Console.WriteLine(exception.Message.ToString());
                goto m3;
            }
            catch (System.OverflowException exception1)
            {
                Console.WriteLine(exception1.Message.ToString());
                goto m3;
            }


        m4:
            Console.WriteLine("zadanie 4");
            try
            {

            }
            catch (System.FormatException exception)
            {
                Console.WriteLine(exception.Message.ToString());
                goto m4;
            }
            catch (System.OverflowException exception1)
            {
                Console.WriteLine(exception1.Message.ToString());
                goto m4;
            }

        m5:
            Console.WriteLine("zadanie 5");
            try
            {
                string a;
                Console.WriteLine("Введите строку");
                string input = Console.ReadLine();
                a = Convert.ToInt32(input, 2).ToString();
                Console.WriteLine(a);
            }
            catch (System.FormatException exception)
            {
                Console.WriteLine(exception.Message.ToString());
                goto m5;
            }
            catch (System.OverflowException exception1)
            {
                Console.WriteLine(exception1.Message.ToString());
                goto m5;
            }

        }
    }
}
