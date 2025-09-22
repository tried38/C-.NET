using System;

public class Class1
{
	public Class1()
	{
        //zadanie 4
        int numb;
        int lastnum;
        int newnum;
        try
        {
            Console.WriteLine("Введите трёхзначное положительное число:");
            numb = Convert.ToInt32(Console.ReadLine());

            if (numb >= 100 && numb <= 999)
            {
                lastnum = numb % 10;
                newnum = lastnum * 100 + numb;
            }

        }
        catch (System.FormatException exception)
        {
            Console.WriteLine(exception.Message.ToString());
        }
        catch (System.OverflowException exception1)
        {
            Console.WriteLine(exception1.Message.ToString());
        }

        Console.ReadKey();
    }
}
