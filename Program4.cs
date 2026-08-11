using System;

internal class Program4
{
    static void Main4(String[] args)
    {
        int marks;

        Console.Write("Enter Marks: ");
        marks = Convert.ToInt32(Console.ReadLine());

        if (marks >= 91 && marks <= 100)
            Console.WriteLine("Grade: O");
        else if (marks >= 81)
            Console.WriteLine("Grade: A+");
        else if (marks >= 71)
            Console.WriteLine("Grade: A");
        else if (marks >= 61)
            Console.WriteLine("Grade: B+");
        else if (marks >= 51)
            Console.WriteLine("Grade: B");
        else
            Console.WriteLine("Fail");
    }
}
