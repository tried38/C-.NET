using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class onlyone
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <returns></returns>
        public int Onlyone(int A, int B, int C)
        {

            if (A > 0 && B < 0 && C < 0)
            {
                return 1;
            }
            else if (A < 0 && B > 0 && C < 0)
            {
                return 1;
            }
            else if (A < 0 && B < 0 && C > 0)
            {
                return 1;
            }
            else
                return -1;
        }
    }
}
