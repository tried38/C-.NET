using System;
using System.Threading.Tasks;
using var18;
namespace PR11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Task 1
            //Даны ненулевые числа x, y. Проверить истинность высказывания: «Точка с координатами(x, y) лежит в первой или третьей координатной четверти».
            Console.WriteLine("Task 1");
            task01 task1 = new task01();
            Console.WriteLine("Vvedit X");
            task1.getX(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Vvedit Y");
            task1.getY(Convert.ToDouble(Console.ReadLine()));
            task1.proverkaChetverti();
            #endregion

            #region Task2
            //Task 2
            //Даны два целых положительных числа A и B (число A меньше числа B). Вывести все нечетные числа, расположенные между данными числами (не включая сами эти числа), в порядке их убывания, а также количество этих чисел и их сумму
            Console.WriteLine("Task 2");
            task02 task2 = new task02();
            Console.WriteLine("Vvedit A");
            task2.getA(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Vvedit B");
            task2.getB(Convert.ToInt32(Console.ReadLine()));
            task2.threeActions();
            #endregion

            #region Task4
            //Task 4
            //Написать функцию int Min4(A, B, C, D) целого типа, возвращающую одно минимальное значение из 4-х своих аргументов (параметры A, B, C и D - целые числа).
            Console.WriteLine("Task 4");
            task04 task4 = new task04();
            Console.WriteLine("Vvedit A");
            task4.getA1(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Vvedit B");
            task4.getB1(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Vvedit C");
            task4.getC1(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Vvedit D");
            task4.getD1(Convert.ToInt32(Console.ReadLine()));
            int minznach = task4.Min4();
            Console.WriteLine($"Минимальное значение: {minznach}");
            #endregion


        }
    }
}
