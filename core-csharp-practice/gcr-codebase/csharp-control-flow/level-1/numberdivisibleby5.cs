using System;

class Random
{
    static void Main(string[] args)
    {
        // Declaring variable
        int number;

        // Taking input from user
        Console.WriteLine("Enter a number");
        number = int.Parse(Console.ReadLine());

        // Checking divisibility by 5
        bool isDivisible = (number % 5 == 0);

        // Displaying result
        Console.WriteLine("Is the number "+number+" divisible by 5? "+isDivisible);
    }
}
