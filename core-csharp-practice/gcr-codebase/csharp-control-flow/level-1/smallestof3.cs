using System;

class Random
{
    static void Main(string[] args)
    {
        // Declaring variables
        int number1, number2, number3;

        // Taking user input
        Console.WriteLine("Enter first number");
        number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number");
        number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter third number");
        number3 = int.Parse(Console.ReadLine());

        // Checking if first number is smallest
        bool isFirstSmallest = (number1 < number2 && number1 < number3);

        // Printing result
        Console.WriteLine("Is the first number the smallest? "+isFirstSmallest);
    }
}
