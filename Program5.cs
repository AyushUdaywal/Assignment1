using System;

internal class Program5
{
    static void Main5(String[] args)
    {
        double a, b;
        int choice;

        Console.Write("Enter First Number: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("Enter Choice: ");
        choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Result = " + (a + b));
                break;
            case 2:
                Console.WriteLine("Result = " + (a - b));
                break;
            case 3:
                Console.WriteLine("Result = " + (a * b));
                break;
            case 4:
                if (b != 0)
                    Console.WriteLine("Result = " + (a / b));
                else
                    Console.WriteLine("Division by zero is not allowed.");
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}