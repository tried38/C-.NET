using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pr03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadanie 1 (Из пяти введенных целых положительных чисел найти два наибольших и вывести произведение этих двух наибольших чисел.)
         m1:
            Console.WriteLine("zadanie 1");
            try
            {
                // Задаем значения x - это любые цифры или числа max значения максимальные из 5-ти x-ов
                int x1, x2, x3, x4, x5;
                int max1, max2;

                //Даем пользователью ввести значения x-ов
                Console.WriteLine("Введите x1: ");
                x1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите x2: ");
                x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите x3: ");
                x3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите x4: ");
                x4 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите x5: ");
                x5 = Convert.ToInt32(Console.ReadLine());

                // Определяем два наибольших числа
                if (x1 > x2)
                {
                    max1 = x1;
                    max2 = x2;
                }
                else
                {
                    max1 = x2;
                    max2 = x1;
                }

                if (x3 > max1)
                {
                    max2 = max1;
                    max1 = x3;
                }
                else if (x3 > max2)
                {
                    max2 = x3;
                }

                if (x4 > max1)
                {
                    max2 = max1;
                    max1 = x4;
                }
                else if (x4 > max2)
                {
                    max2 = x4;
                }

                if (x5 > max1)
                {
                    max2 = max1;
                    max1 = x5;
                }
                else if (x5 > max2)
                {
                    max2 = x5;
                }

                // Находим произведение двух чисел
                int product = max1 * max2;
                //Выводим результат
                Console.WriteLine($"Два наибольших числа: {max1} и {max2}");
                Console.WriteLine($"Произведение этих чисел: {product}");
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
            //zadanie 2 (Даны шесть целых ненулевых положительных чисел. Найти сумму трех наименьших чисел.)
        m2:
            Console.WriteLine("\n");
            Console.WriteLine("zadanie 2");
            try
            {
                // Задаем значения a -это любые цифры или числа
                int a1, a2, a3, a4, a5, a6;

                //Даем пользователью ввести значения a(1-6)
                Console.WriteLine("Введите a1: ");
                a1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите a2: ");
                a2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите a3: ");
                a3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите a4: ");
                a4 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите a5: ");
                a5 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите a6: ");
                a6 = Convert.ToInt32(Console.ReadLine());

                // Инициализируем три наименьших числа большим значением
                int minA1 = int.MaxValue, minA2 = int.MaxValue, minA3 = int.MaxValue;

                // Находим три наименьших числа
                if (a1 < minA1) 
                { 
                    minA3 = minA2; 
                    minA2 = minA1;
                    minA1 = a1; 
                }
                else if (a1 < minA2) 
                { 
                    minA3 = minA2; 
                    minA2 = a1; 
                }
                else if (a1 < minA3) 
                { 
                    minA3 = a1; 
                }

                if (a2 < minA1) 
                { 
                    minA3 = minA2; 
                    minA2 = minA1; 
                    minA1 = a2; 
                }
                else if (a2 < minA2) 
                { 
                    minA3 = minA2; 
                    minA2 = a2; 
                }
                else if (a2 < minA3)
                { 
                    minA3 = a2; 
                }

                if (a3 < minA1) 
                { 
                    minA3 = minA2; 
                    minA2 = minA1; 
                    minA1 = a3; 
                }
                else if (a3 < minA2) 
                {
                    minA3 = minA2; 
                    minA2 = a3;
                }
                else if (a3 < minA3) 
                { 
                    minA3 = a3; 
                }

                if (a4 < minA1) 
                {
                    minA3 = minA2; 
                    minA2 = minA1; 
                    minA1 = a4; 
                }
                else if (a4 < minA2) 
                {
                    minA3 = minA2; 
                    minA2 = a4; 
                }
                else if (a4 < minA3) 
                { 
                    minA3 = a4; 
                }

                if (a5 < minA1) 
                { 
                    minA3 = minA2; 
                    minA2 = minA1;
                    minA1 = a5; 
                }
                else if (a5 < minA2) 
                { 
                    minA3 = minA2; 
                    minA2 = a5; 
                }
                else if (a5 < minA3) 
                { 
                    minA3 = a5; 
                }

                if (a6 < minA1) 
                { 
                    minA3 = minA2; 
                    minA2 = minA1; 
                    minA1 = a6; 
                }
                else if (a6 < minA2) 
                { 
                    minA3 = minA2; 
                     minA2 = a6; 
                }
                else if (a6 < minA3) 
                { 
                    minA3 = a6; 
                }

                // Суммируем три наименьших числа
                int sum = minA1 + minA2 + minA3;

                // Выводим результат
                Console.WriteLine("Сумма трех наименьших чисел: {0}", sum);
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

            // zadanie 4 (Дан целочисленный массив, состоящий из N элементов (N > 0, N может быть четным или нечетным числом). Поменять порядок следования его элементов на обратный. Вычислить и вывести сумму и произведение всех его элементов.)\
           m4:
            Console.WriteLine("\n");
            Console.WriteLine("zadanie 4");
            try
            { 
            int[] numbers = new int[35]; //сам массив
            int n = numbers.Length; // длина массива
            int k = n / 2;          // середина массива
            int temp;               // вспомогательный элемент для обмена значениями
            int proizvedenie = 1;

            Console.Write("Пожалуйста, сделайте свой выбор (1 - авто массив; 2 - ручной массив): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();

            switch (choice)
            {
                case 1:
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = rand.Next(20);
                    }
                    break;

                case 2:
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.WriteLine("Введите значение для элемента массива №" + i);
                        numbers[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    break;

                default:
                    Console.WriteLine("Неверный выбор.");
                    goto m4;
            }

            // Обмен значений (реверс массива)
            for (int i = 0; i < k; i++)
            {
                temp = numbers[i];
                numbers[i] = numbers[n - i - 1];
                numbers[n - i - 1] = temp;
            }

            // Вычисление произведения элементов массива
            for (int i = 0; i < n; i++)
            {
                proizvedenie *= numbers[i];
            }

            // Вычисление суммы элементов массива
            int sum_massiva = numbers.Sum();
            string result = string.Join(", ", numbers);

            Console.WriteLine("Массив в обратном порядке: " + result);
            Console.WriteLine("Сумма элементов массива: " + sum_massiva);
            Console.WriteLine("Произведение элементов массива: " + proizvedenie);
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

        // zadanie 5 Дан массив ненулевых целых чисел, признак его завершения - число 0. Вывести на экран все положительные нечетные числа из данного набора, а строкой ниже вывести их сумму. Если требуемые числа в наборе отсутствуют, то вывести значение -1.
        m5:
            Console.WriteLine("\n");
            Console.WriteLine("zadanie 5");
            try
            {
                int[] numbers1 = new int[40];
                int count = 0; // Счетчик для количества введенных чисел
                int sum_nechet = 0; // Сумма нечетных чисел
                bool polojitelnie_chisla = false;
                // цикл for для ввода чисел или цифр в массив (признак его завершения - число 0)
                for (int i = 0; i < numbers1.Length; i++)
                {
                    Console.WriteLine("Введите значение для элемента массива №" + (i + 1) + " (0 для завершения):");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                        break;
                    numbers1[i] = input;
                    count++;
                }
                // Создаем массив с введенными значениями
                int[] actualNumbers = new int[count];

                string result1 = string.Join(", ", actualNumbers);
                Console.WriteLine("Массив: " + result1);

                // Вывести на экран все положительные нечетные числа из данного набора(в другой массив)
                Console.WriteLine("Нечетные числа: ");
                // Суммируем нечетные числа
                for (int i = 0; i < count; i++)
                {
                    if (actualNumbers[i] > 0 && actualNumbers[i] % 2 != 0) // Проверка на нечетность и на положительность
                    {
                        Console.Write(actualNumbers[i] + " "); // Выводим положительное нечетное число
                        sum_nechet += actualNumbers[i]; // Суммируем только нечетные числа
                        if (actualNumbers[i] > 0) // Проверка на положительность
                        {
                            Console.Write(actualNumbers[i] + " "); // Выводим положительное нечетное число
                        }
                    }
                }
                Console.WriteLine("\n");
                if (!polojitelnie_chisla)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Console.WriteLine("\nСумма положительных нечетных чисел: " + sum_nechet);
                }
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

        // zadanie 3 (Дан целочисленный массив, состоящий из N элементов (N > 0, N может быть четным или нечетным числом). Поменять порядок следования его элементов на обратный. Вычислить и вывести сумму и произведение всех его элементов.)\
        m3:
            Console.WriteLine("\n");
            Console.WriteLine("zadanie 3");
            try
            {
                Random rand1 = new Random();
                int daysVmonth;
                Console.WriteLine("Введите число дней (в месяце 28, 29 или 31): ");
                daysVmonth = Convert.ToInt32(Console.ReadLine());

                if ((daysVmonth < 28 || daysVmonth > 31))
                {
                    Console.WriteLine("Некоректно введено число");
                    goto m3;
                }

                int[] osadki = new int[daysVmonth];

                // Заполнение массива случайными числами (количество осадков от 0 до 100 мм)
                for (int i = 0; i < daysVmonth; i++)
                {
                    osadki[i] = rand1.Next(0, 101); // Генерация случайного числа с двумя знаками после запятой
                    Console.WriteLine($"День {i + 1}: {osadki[i]} мм осадков");
                }

                double evenSum = 0; // Сумма осадков в четные дни
                double oddSum = 0; // Сумма осадков в нечетные дни

                // Суммирование осадков по четным и нечетным дням
                for (int i = 0; i < daysVmonth; i++)
                {
                    if ((i + 1) % 2 == 0) // Четный день
                    {
                        evenSum += osadki[i];
                    }
                    else // Нечетный день
                    {
                        oddSum += osadki[i];
                    }
                }

                // Проверка условия и вывод результата
                if (evenSum > oddSum)
                {
                    Console.WriteLine("\nВ четные дни выпало больше осадков: " + evenSum + " мм против " + oddSum + " мм в в нечетные дни..");
                }
                else if (evenSum < oddSum)
                {
                    Console.WriteLine("\nВ нечетные дни выпало больше осадков: " + oddSum + " мм против " + evenSum + " мм в четные дни.");
                }
                else
                {
                    Console.WriteLine("\nКоличество осадков в четные и нечетные дни одинаковое:" + evenSum + " мм.");
                }
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
            Console.ReadKey();
        }
    }
}
