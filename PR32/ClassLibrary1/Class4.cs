using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class4
    {
        public static int massiv (int[] mas)
        {
            bool flag = false;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < 0 && mas[i] % 2 == 0)
                { flag = true; break; }
            }

            int sum = 0;
            if (flag)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] > 0 && mas[i] % 2 != 0)
                    {
                        sum += mas[i];
                    }
                }
            }

            else
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] % 3 == 0)
                    {
                        sum += mas[i];
                    }
                }
            }
            return sum;
        }
    }
}
