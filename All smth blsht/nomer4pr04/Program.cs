using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomer4pr04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите строку, состоящую из слов, разделенных подчеркиваниями: ");
            string input = Console.ReadLine();

            // Разделяем строку на слова по подчеркиваниям
            string[] words = input.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);

            // Перебираем слова и проверяем условия
            foreach (string word in words)
            {
                if (word.Length > 0 && (word[0] == '3' || word[0] == '7') && word[word.Length - 1] == '1')
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
            
