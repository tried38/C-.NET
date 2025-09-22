using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var18
{
    public class task01
    {
        public static bool isnumberthreedigit(int A)
        {
            if (A < 0)
                return false;
            else if ((A >= 100 && A <= 999) && (A % 2 == 0))
                return true;
            else
                return false;
        }
    }
}
