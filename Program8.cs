using System;

internal class Program8
{
    static void Main8(String[] args)
    {
        int n;
        bool prime = true;

        Console.Write("Enter Number: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n <= 1)
            prime = false;
        else
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }
        }

        if (prime)
            Console.WriteLine("Prime Number");
        else
            Console.WriteLine("Not Prime Number");
    }
}