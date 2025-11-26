using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class2
    {
        public static int product(int four)
        {
            if (four > 0 && four > 999 && four<10000)
            {
                int N1 = four / 1000;
                int N2 = (four / 100) % 10;
                int N3 = (four / 10) % 10;
                int N4 = four % 10;
                int N5 = N1 * N2;
                int N6 = N3 * N4;
                int sum = N5 + N6;
                return sum;
            }
            else { return 0; }
        }
    }
}
