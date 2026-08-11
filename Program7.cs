using System;

internal class Program7
{
    static void Main7(String[] args)
    {
        int n;
        long fact = 1;

        Console.Write("Enter a Number: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }

        Console.WriteLine("Factorial = " + fact);
    }
}
