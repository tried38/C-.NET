using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary2;

namespace pr24
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zad1
            onlyone str = new onlyone();
            int A = 1;
            int B = -2;
            int C = -3;
            int a = str.Onlyone(A, B, C);
            Console.WriteLine(a);

            //Zad2 
            count count = new count();
            int k = 1234567;
            int n = 5;
            int counter = count.Count(k, n);
            Console.WriteLine(counter);
            Console.ReadKey();
        }
    }
}
