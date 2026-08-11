using System;

internal class Program9
{
    static void Main9(String[] args)
    {
        int num, rev = 0, rem, temp;

        Console.Write("Enter Number: ");
        num = Convert.ToInt32(Console.ReadLine());

        temp = num;

        while (num > 0)
        {
            rem = num % 10;
            rev = rev * 10 + rem;
            num /= 10;
        }

        if (temp == rev)
            Console.WriteLine("Palindrome Number");
        else
            Console.WriteLine("Not a Palindrome Number");
    }
}
10.Me