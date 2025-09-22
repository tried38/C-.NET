using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void CoordinateQuarter(int x, int y)
        {
            if (x > 0 || y < 0)
            {
                Console.WriteLine("Точка с координатами x = {0} и y = {1} лежит в четвертой координатной четверти", x, y);
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Не подходит под условие (числа x, y - ненулевые)");
            }
            else
            {
                Console.WriteLine("Точка с координатами x = {0} и y = {1} НЕ лежит в четвертой координатной четверти", x, y);
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число y:");
            int y = Convert.ToInt32(Console.ReadLine());
            CoordinateQuarter(x, y);
        }
    }
}
