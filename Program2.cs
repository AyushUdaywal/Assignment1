using System;

internal class Program2
{
    static void Main2(String[] args)
    {
        int a, b;

        Console.Write("Enter First Number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sum = " + (a + b));
        Console.WriteLine("Difference = " + (a - b));
        Console.WriteLine("Product = " + (a * b));
        Console.WriteLine("Quotient = " + (a / b));
        Console.WriteLine("Remainder = " + (a % b));
    }
}
