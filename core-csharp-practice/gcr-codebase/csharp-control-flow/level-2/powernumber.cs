using System;

class Random
{
    static void Main(string[] args)
    {
        // User Input
        Console.WriteLine("Enter base number");
        int number = int.Parse(Console.ReadLine());

        // User Input 
        Console.WriteLine("Enter power");
        int power = int.Parse(Console.ReadLine());

        int result = 1;

        // Calculating power
        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }

        // Displaying result
        Console.WriteLine("Result is "+result);
    }
}
