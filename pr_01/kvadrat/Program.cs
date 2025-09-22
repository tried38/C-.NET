using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kvadrat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону квадрата:");
            int storona = Convert.ToInt32(Console.ReadLine());

            int perimetr = 4 * storona;
            Console.WriteLine("Периметр квадрата");
            Console.WriteLine(perimetr); 
            Console.WriteLine("кв.см");
        }
    }
}
