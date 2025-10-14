using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr25
{
    internal class Class1
    {
        public bool IsSquare(int K)
        {
            if (K <= 0)
                return false;
            int k = (int)Math.Sqrt(K);
            return k * k == K;
        }
    }
}
