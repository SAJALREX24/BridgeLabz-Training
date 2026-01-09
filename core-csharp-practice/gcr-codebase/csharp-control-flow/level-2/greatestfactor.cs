using System;

class Random
{
    static void Main(string[] args)
    {
        // User Input 
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());

        int greatestFactor = 1;

        
        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0)
            {
                greatestFactor = i;
                break;
            }
        }

        // Displaying result
        Console.WriteLine("Greatest factor is "+greatestFactor);
    }
}
