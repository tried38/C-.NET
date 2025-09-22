using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_01
{
    internal class Ploshad_poverhnosti_cilindra
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус основания:");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите высоту цилиндра:");
            double height = Convert.ToDouble(Console.ReadLine());


            double Spc = 2 * Math.PI * radius * (height + radius);
            Console.WriteLine("Площадь поверхности цилиндра: кв.см");
            Console.WriteLine(Spc);
        }
    }
}
