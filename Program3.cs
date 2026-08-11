using System;

internal class Program3
{
    static void Main3(String[] args)
    {
        int num;

        Console.Write("Enter a Number: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
            Console.WriteLine("Positive Number");
        else if (num < 0)
            Console.WriteLine("Negative Number");
        else
            Console.WriteLine("Zero");
    }
}