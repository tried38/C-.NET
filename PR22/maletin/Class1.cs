using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace maletin
{
    public class Class1
    {
        //Zadanie1
        public int positivenum(int A, int B, int C)
        {
            if (A == 0 && B == 0 && C == 0)
                { return 0; }
            else
            {
                if (A>0 || B>0 || C>0)
                    { return 1; }
                else 
                    { return -1; }
            }
        }
        //Zadanie2
        public int difference(int D)
        {
            if (D >= 1000 && D <= 9999 && D > 0)
            {
                int D1 = D / 1000;
                int D2 = (D / 100) % 10;
                int D3 = (D / 10) % 10;
                int D4 = D % 10;
                int D5 = D1*D2 ;
                int D6 = D3*D4;
                int diff = D5 - D6;
                return diff;
            }
            else
            {
                return -1;
            }
        }
        //Zadanie3
        public int Min3(int E, int F, int G)
        {
            if (E <= F && E <= G)
            {
                return E;
            }
            else if (F <= E && F <= G)
            {
                return F;
            }
            else
            {
                return G;
            }
        }
    }
}
