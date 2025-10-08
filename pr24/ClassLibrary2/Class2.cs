using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class count
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="K"></param>
        /// <param name="N"></param>
        /// <returns></returns>
        public  int Count(int K, int N)
        {
            if (K <= 0)
            {
                return -1;
            }
            if (N <= 0)
            {
                return -1;
            }

            int count = 0;
            int temp = K;
            while (temp > 0)
            {
                count++;
                temp /= 10;
            }
            if (count < N)
            {
                return -1;
            }

            for (int i = 1; i < N; i++)
            {
                K /= 10;
            }

            return K % 10;
        }
    }
}
