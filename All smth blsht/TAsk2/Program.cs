using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAsk2
{
    internal class Program
    {
        //Вводится строка-предложение.Длина строки может быть разной.
        //Подсчитать количество содержащихся в строке знаков препинания
        //(точка, запятая, двоеточие, точка с запятой, восклицательный знак, вопросительный знак).
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
            Console.WriteLine("Введите строку (в которой могут содержаться знаки препинаиня");
            string inputstorka = Console.ReadLine().ToLower();
            Countznaki(inputstorka);
        }
    }
}
