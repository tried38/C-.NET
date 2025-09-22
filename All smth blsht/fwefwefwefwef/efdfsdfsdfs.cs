using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fwefwefwefwef
{
    internal class efdfsdfsdfs
    {
        static string TimeToDay(int H, int M, int S)
        {
            int intotalday = ((H * 3600) + (M * 60) + S) / 86400;
            return intotalday.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число H - часы:");
            int H = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число M - минуты:");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число S - секунды:");
            int S = Convert.ToInt32(Console.ReadLine());

            string days = TimeToDay(H, M, S);
            Console.WriteLine("Прошло дней " + days);
        }
    }
}
