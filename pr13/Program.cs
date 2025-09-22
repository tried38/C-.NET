using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr13
{
    internal class Program
    {
        static void Main(string[] args)
        {
        m:
            try
            {
                #region Zadanie1
                task01 task1 = new task01();
                Console.WriteLine("Vvdite cm");
                int L1 = 0;
                int L = task1.getcm(Convert.ToInt32(Console.ReadLine()));
                if (L <= 0)
                {
                    Console.WriteLine("Расстояние должно быть положительным числом");
                }
                else
                {
                    L1 = L / 100;
                }
                Console.WriteLine($"количество полных метров в {L} - {L1}");
                #endregion
                Console.WriteLine(new string('-', 70));
                #region Zadanie3
                
                #endregion
                Console.WriteLine(new string('-', 70));
                #region Zadanie4
                
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto m;
            }
        }
    }
}
