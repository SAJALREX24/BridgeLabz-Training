using System;

class Random
{
    static void Main(string[] args)
    {
        // User Input
        Console.WriteLine("Enter a positive integer");
        int number = int.Parse(Console.ReadLine());

        // Checking if the number is a natural number
        if (number > 0)
        {
            int factorial = 1;
            int counter = 1;

            
            while (counter <= number)
            {
                factorial *= counter;
                counter++;
            }

            // Displaying factorial
            Console.WriteLine("Factorial of  "+number+" is  "+factorial);
        }
        else
        {
            // Invalid input message
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}
