using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Class1
{
	public Class1()
	{
        // zadanie 4 (Дан целочисленный массив, состоящий из N элементов (N > 0). Найти сумму и произведение всех нечетных чисел из данного массива.)
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
        int n = numbers.Length; // длина массива
        int k = n / 2;          // середина массива
        int temp;               // вспомогательный элемент для обмена значениями
        for (int i = 0; i < k; i++)
        {
            temp = numbers[i];
            numbers[i] = numbers[n - i - 1];
            numbers[n - i - 1] = temp;
        }
        foreach (int i in numbers)
        {
            Console.WriteLine($"{i} \t");
        }
    }
}
