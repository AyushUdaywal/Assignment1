using System;

internal class Program
{
    static void Main1(String[] args)
    {
        string name;
        int rollNo;
        float marks;

        Console.Write("Enter Student Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Roll Number: ");
        rollNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Marks: ");
        marks = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("\n--- Student Details ---");
        Console.WriteLine("Name       : " + name);
        Console.WriteLine("Roll No    : " + rollNo);
        Console.WriteLine("Marks      : " + marks);
    }
}
