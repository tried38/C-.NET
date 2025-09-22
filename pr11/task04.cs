using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var18
{
    internal class task04
    {
        int chisloA1 = 0;
        int chisloB1 = 0;
        int chisloC1 = 0;
        int chisloD1 = 0;

        public void getA1(int A1)
        {
            chisloA1 = A1;
        }

        public void getB1(int B1)
        {
            chisloB1 = B1;
        }

        public void getC1(int C1)
        {
            chisloC1 = C1;
        }

        public void getD1(int D1)
        {
            chisloD1 = D1;
        }
        public int Min4()
        {
            return Math.Min(Math.Min(chisloA1, chisloB1), Math.Min(chisloC1, chisloD1));
        }
    }
}
