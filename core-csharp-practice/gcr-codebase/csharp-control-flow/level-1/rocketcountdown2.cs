using System;

class Random
{
    static void Main(string[] args)
    {
        // Declaring variable
        int startValue;

        // Taking Input
        Console.WriteLine("Enter countdown start value");
        startValue = int.Parse(Console.ReadLine());

        
        for (int i = startValue; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Launch");
    }
}
