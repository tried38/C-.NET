using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var18
{
    class task01
    {
        double tochkax = 0;
        double tochkay = 0;
        public void getX(double x)
        {
            tochkax = x;
        }
        public void getY(double y)
        {
            tochkay = y;
        }
        public void proverkaChetverti()
        {
            if (tochkax > 0 && tochkay > 0)
            {
                System.Console.WriteLine("Точка находится в первой четверти");
            }
            else if (tochkax < 0 && tochkay < 0)
            {
                System.Console.WriteLine("Точка находится в третьей четверти");
            }
            else
            {
                System.Console.WriteLine("Точка НЕ находится ни в первой ни в третьей четверти");
            }
        }
    }

}
