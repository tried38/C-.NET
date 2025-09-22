using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_pr_21
{
    internal class Program
    {
        static double TriangleS(double a)
        {
            return (a * a * Math.Sqrt(3)) / 4;
        }
        static void Main(string[] args)
        {
            //zad 1
            double a1 = Convert.ToDouble(Console.ReadLine());
            double a2 = Convert.ToDouble(Console.ReadLine());
            double a3 = Convert.ToDouble(Console.ReadLine());
            double area1 = TriangleS(a1);
            double area2 = TriangleS(a2);
            double area3 = TriangleS(a3);
            Console.WriteLine($"Площадь первого треугольника: {area1}");
            Console.WriteLine($"Площадь второго треугольника: {area2}");
            Console.WriteLine($"Площадь третьего треугольника: {area3}");
        }
    }
}
