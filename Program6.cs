using System;

internal class Program6
{
    static void Main6(String[] args)
    {
        int n;

        Console.Write("Enter N: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Even Numbers:");
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
                Console.Write(i + " ");
        }

        Console.WriteLine("\nOdd Numbers:");
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 != 0)
                Console.Write(i + " ");
        }
    }
}