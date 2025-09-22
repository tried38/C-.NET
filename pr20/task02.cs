using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var18
{
    public class task02
    {
        public static int product_of_numbers(int B, int C)
        {
            int product = 1;
            if (B <= 0 && C <= 0)
            {
                return 0;
            }
            else
            {
                if (B > C)
                {
                    return 0;
                }
                else
                {
                    for (int i = B+1; i < C; i++)
                    {
                        if ((i % 2) == 0)
                        {
                            product *= i;
                        }
                    }
                }
            }
            return product;
        }
    }
}
