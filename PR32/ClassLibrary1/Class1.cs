using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public  class Class1
    {
        /// <summary>
        /// Проверить истинность высказывания
        /// Данное целое положительное число является нечетным трехзначным числом 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool Odd(int x)
        { 
            if (x > 0 && x > 99 && x < 1000 && x%2!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
