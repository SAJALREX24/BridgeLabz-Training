using System;

class Random
{
    static void Main(string[] args)
    {
        // Declaring variable
        int number;

        // Taking Input
        Console.WriteLine("Enter a number");
        number = int.Parse(Console.ReadLine());

       
        if (number > 0)
        {
            Console.WriteLine("Positive");
        }
        else if (number < 0)
        {
            Console.WriteLine("Negative");
        }
        else
        {
            Console.WriteLine("Zero");
        }
    }
}
