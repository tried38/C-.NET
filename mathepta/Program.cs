using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathepta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zadanie 4");
            Console.WriteLine("Введите строку");
            string input = Console.ReadLine();
            int length = input.Length;
            int result = 0;
            char operation = '+';
            if (length < 3)
            {
                Console.WriteLine("Минимальный размер строки (массив символов) - не менее 2 символов (для операций вичисления)");
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    char newChar = input[i];
                    if (char.IsDigit(newChar)) // Если символ - цифра
                    {
                        int number = newChar - '0'; // Преобразуем символ в число

                        if (operation == '+')
                        {
                            result += number; // Сложение
                        }
                        else if (operation == '-')
                        {
                            result -= number; // Вычитание
                        }
                    }
                    else if (newChar == '+' || newChar == '-') // Если символ - оператор
                    {
                        operation = newChar; // Обновляем текущую операцию
                    }
                }
                Console.WriteLine(result);

            }
        }
    }
}
