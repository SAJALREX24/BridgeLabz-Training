using System;

class Random
{
    static void Main(string[] args)
    {
        // Declaring variables
        int number;
        int sum;

        // Taking input from user
        Console.WriteLine("Enter a number");
        number = int.Parse(Console.ReadLine());

        // Checking if number is natural
        if (number > 0)
        {
            sum = number * (number + 1) / 2;

            // Displaying output
            Console.WriteLine("The sum of "+number+" natural numbers is "+sum);
        }
        else
        {
            // Displaying output
            Console.WriteLine("The number "+number+" is not a natural number");
        }
    }
}
