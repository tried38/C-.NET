using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_01
{
    internal class treygolnik
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите основание треугольника:");
            double osnovanie = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту треугольника:");
            int height = Convert.ToInt32(Console.ReadLine());

            double ploshad_t = (osnovanie * height) / 2;
            Console.WriteLine("Площадь треугольника кв.см:");
            Console.WriteLine(ploshad_t);

        }
    }
}