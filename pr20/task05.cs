using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr20
{
    public class task05
    {
        public static int DecToOct(int D)
        {
            if (D == 0) return 0;
            int oct = 0;
            int place = 1;
            while (D > 0)
            {
                int remainder = D % 8;
                oct += remainder * place;
                D /= 8;
                place *= 10;
            }
            return oct;
        }
    }
}
