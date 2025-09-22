using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1337
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zadanie 5");
            Console.WriteLine("Введите строку");
            string input = Console.ReadLine().ToLower(); // Считываем строку и приводим к нижнему регистру
            char previousChar = '\0'; // Инициализируем предыдущий символ
            bool isOrdered = true; // Флаг, указывающий, упорядочены ли буквы

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                // Проверяем, является ли текущий символ буквой
                if (char.IsLetter(currentChar))
                {
                    // Если предыдущий символ не инициализирован, просто обновляем его
                    if (previousChar == '\0')
                    {
                        previousChar = currentChar;
                        continue;
                    }

                    // Проверяем, что буквы идут в алфавитном порядке
                    if (currentChar < previousChar)
                    {
                        Console.WriteLine(i + 1); // Выводим позицию нарушения (индекс + 1)
                        isOrdered = false; // Устанавливаем флаг нарушения
                        break; // Выходим из цикла
                    }

                    // Обновляем предыдущий символ
                    previousChar = currentChar;
                }
            }

            // Если порядок не нарушен, выводим 0
            if (isOrdered)
            {
                Console.WriteLine(0);
            }

            Console.ReadKey();
        }
    }
}
