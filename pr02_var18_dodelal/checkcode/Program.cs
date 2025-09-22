using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            try
            {
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
            catch (System.FormatException exception)
            {
                Console.WriteLine(exception.Message.ToString());
            }
            catch (System.OverflowException exception1)
            {
                Console.WriteLine(exception1.Message.ToString());
            }

            Console.ReadKey();

        }
    }
}
