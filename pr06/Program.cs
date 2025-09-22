using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа номер 6");
            Console.WriteLine("Вариант 18");
            Console.WriteLine("Выполнил Малетин Алексей");
            Console.WriteLine("Zadanie1");
        //Дано целое положительное трехзначное число N(N> 0). 
        //Проверить истинность высказывания: 
        //«Данное число N читается одинаково слева направо и справа налево».
        m1:
            try
            {
                int A;
                int A1;
                int A2;
                int A3;
                Console.WriteLine("Введите А:");
                A = Convert.ToInt32(Console.ReadLine());
                if (A < 0 | A < 100 | A > 999)
                {
                    Console.WriteLine("Число не подходит под условие задания");
                    goto m1;
                }
                else
                {
                    A1 = A / 100;
                    A2 = (A / 100) % 10;
                    A3 = A % 10;
                    if (A1 == A3)
                    {
                        Console.WriteLine($"Данное число {A} читается одинаково слева направо и справа налево");
                    }
                    else
                    {
                        Console.WriteLine($"Данное число {A} НЕ читается одинаково слева направо и справа налево");
                    }
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

            Console.WriteLine("Zadanie2");
        //Дано целое число N(N > 0).
        //Если N - нечетное, то вывести произведение нечетных чисел до этого числа(1 * 3 * 5 * N); 
        //если N -четное, то вывести произведение четных чисел до этого числа(2 * 4 * 6 * N). 
        //Чтобы избежать целочисленного переполнения, вычислять это выражение с помощью вещественной переменной и выводить его как вещественное число. 
        //(Пример, 6 = 2 * 4 * 6; 9 = 1 * 3 * 5 * 7 * 9).
        m2:
            try
            {
                int N = 0;
                Console.WriteLine("Введите N");
                N = Convert.ToInt32(Console.ReadLine());
                double proizvedenie = 1;
                string primer = "";
                if (N < 0)
                {
                    Console.WriteLine("Число не подходит под условие задачи");
                    goto m2;
                }
                else
                {
                    if (N % 2 == 1)
                    {
                        for (int i = 1; i <= N; i += 2)
                        {
                            proizvedenie *= i;
                            primer += i + (i < N ? "*" : "");
                        }
                    }
                    if (N % 2 == 0)
                    {
                        for (int i = 2; i <= N; i += 2)
                        {
                            proizvedenie *= i;
                            primer += i + (i < N ? "*" : "");
                        }
                    }
                }
                Console.WriteLine($"Произведение до числа {N} = {primer} = {proizvedenie}");

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

            Console.WriteLine("Zadanie3");
        //Дан целочисленный массив, состоящий из N элементов(N > 0). 
        //Найти максимальный и минимальный элемент в массиве и вычислить их сумму.
        m3:
            try
            {
                int N;
                int summa = 0;
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
                int maxznach = m.Max();
                int minznach = m.Min();
                summa = maxznach + minznach;
                int[] samArray = m;
                string originalResult = string.Join(", ", samArray);
                Console.WriteLine("Сам массив: " + originalResult);
                Console.WriteLine("Сумма max и min элемента = " + summa);
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

            Console.WriteLine("Zadanie 4");
            //Вводится строка, изображающая целочисленное арифметическое выражение вида «цифра_цифра_цифра_цифра», 
            //где на месте знака операции «_» находится символ «+» или «-», а на месте "цифра" находится одна из цифр(от 1 до 9). 
            //Например, «4 + 7 - 2 + 5». 
            //Вывести значение данного выражения(как целое число).
        m4:
            try
            {
                Console.WriteLine("Введите строку");
                string input1 = Console.ReadLine();
                int result = 0;
                int number = 0;
                char operation = '+';
                for (int i = 0; i < input1.Length; i++)
                {
                    char currentChar = input1[i];
                    if (char.IsDigit(currentChar))
                    {
                        number = currentChar - '0';
                        if (operation == '+')
                        {
                            result += number;
                        }
                        else if (operation == '-')
                        {
                            result -= number;
                        }
                    }
                    else if (currentChar == '+' || currentChar == '-')
                    {
                        operation = currentChar;
                    }
                }
                Console.WriteLine("Результат: " + result);
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
                goto m4;
            }
            catch (OverflowException exception1)
            {
                Console.WriteLine(exception1.Message);
                goto m4;
            }

            Console.WriteLine("Zadanie5");
        //Вводится строка, состоящая из слов, разделенных подчеркиваниями(одним или несколькими).
        //Длина строки может быть разной. Строка содержит цифры и строчные латинские буквы.
        //Если буквы в строке упорядочены по алфавиту, то вывести 0;
        //В противном случае вывести номер первого символа строки, нарушающего алфавитный порядок.
        m5:
            try
            {
                Console.WriteLine("Введите строку");
                string inputstring = Console.ReadLine().ToLower();
                char predChar = '\0'; //считываем предыдущий символ
                bool uporadochenn = true; // Флаг, указывающий, упорядочены ли буквы

                for (int i = 0; i < inputstring.Length; i++)
                {
                    char sledChar = inputstring[i];
                    // Проверяем, является ли текущий символ буквой
                    if (char.IsLetter(sledChar))
                    {
                        if (predChar == '\0')
                        {
                            predChar = sledChar;
                            continue;
                        }
                        // Проверяем, что буквы идут в алфавитном порядке
                        if (sledChar < predChar)
                        {
                            Console.WriteLine(i + 1); // Выводим позицию нарушения (индекс + 1)
                            uporadochenn = false; // Устанавливаем флаг нарушения
                            break; // Выходим из цикла
                        }
                        // Обновляем предыдущий символ
                        predChar = sledChar;
                    }
                }
                // Если порядок не нарушен, выводим 0
                if (uporadochenn)
                {
                    Console.WriteLine(0);
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
        }
    }
}
