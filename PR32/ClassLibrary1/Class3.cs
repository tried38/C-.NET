using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class3
    {
        public static double DegToRad(double D)
        {
            if (D >= 0 && D <= 360)
            {
                return D * (Math.PI / 180.0);
            }
            else { return 0; }
        }
    }
}
