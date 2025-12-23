using System;

class Random
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter a positive integer:");
        int number = int.Parse(Console.ReadLine());

        // Checking for natural number
        if (number > 0)
        {
            int factorial = 1;

            
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            // Displaying result
            Console.WriteLine("Factorial of "+number+" is "+factorial);
        }
        else
        {
            Console.WriteLine("Entered number is not a natural number.");
        }
    }
}
