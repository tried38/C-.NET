using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var18
{
    class task02
    {
        int chisloA = 0;
        int chisloB = 0;
        int count = 0;
        public void getA (int A)
        {
            chisloA = A;
        }
        public void getB(int B)
        {
            chisloB = B;
        }
        public void threeActions()
        {
            if (chisloA > chisloB)
            {
                Console.WriteLine("По заданию число A меньше числа B");
            }
            for (int i = chisloA+1; i < chisloB; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }
            int[] numbers = new int[count];
            int index = 0;
            int summa = 0;
            for (int i = chisloA + 1; i < chisloB; i++)
            {
                if (i % 2 != 0)
                {
                    numbers[index] = i;
                    summa += i;
                    index++;
                }
            }
            string massiv = string.Join(", ", numbers);
            Console.WriteLine("Нечетные числа между A и B (в порядке убывания):");
            Console.WriteLine(massiv);
            Console.WriteLine($"Сумма этих чисел {summa}");
            Console.WriteLine($"количество нечетных чисел, расположенные между {chisloA} и {chisloB} (не включая {chisloA} и {chisloB}) - {count}");
        }
    }
}
