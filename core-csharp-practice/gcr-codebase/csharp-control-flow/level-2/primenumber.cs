using System;

class Random
{
    static void Main(string[] args)
    {
        // User Input 
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        
        bool Prime = number > 1;

        
        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                Prime = false;
                break;
            }
        }

        // Displaying result
        Console.WriteLine(Prime ? "Prime Number" : "Not a Prime Number");
    }
}
