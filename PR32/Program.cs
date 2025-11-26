using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace PR32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1 \nВведите трехзначное число");
            int x = Convert.ToInt32(Console.ReadLine());
            bool result1 = Class1.Odd(x);
            Console.WriteLine(result1);

            Console.WriteLine("Task 2 \nВведите четырехзначное число");
            int four = Convert.ToInt32(Console.ReadLine());
            int result2 = Class2.product(four);
            Console.WriteLine(result2);

            Console.WriteLine("Task 3 \nВведите величину D (0 >= D <= 360)");
            double D = Convert.ToDouble(Console.ReadLine());
            double result3 = Class3.DegToRad(D);
            Console.WriteLine(result3);


            Console.WriteLine("Task 4 \nВведите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n <= 0)
            {
                Console.Write("Размер должен быть больше 0. Введите снова: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            int[] numbers = new int[n];
        m4:
            Console.Write("Пожалуйста, сделайте свой выбор (1 - авто массив; 2 - ручной массив): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            switch (choice)
            {
                case 1:
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = rand.Next(-50, 51); // от -50 до 50 для отрицательных чисел
                    }
                    break;

                case 2:
                    Console.WriteLine($"Введите {n} элементов массива:");
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.Write($"Элемент {i + 1}: ");
                        numbers[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    break;

                default:
                    Console.WriteLine("Неверный выбор.");
                    goto m4;
            }

            int result4 = Class4.massiv(numbers);
            Console.WriteLine(result4);
        }
    }
}
