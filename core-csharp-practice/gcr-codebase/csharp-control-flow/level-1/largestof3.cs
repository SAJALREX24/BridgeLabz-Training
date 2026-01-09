using System;

class Random
{
    static void Main(string[] args)
    {
        // Variable declaration
        int number1, number2, number3;

        // Taking input from user
        Console.WriteLine("Enter first number");
        number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number");
        number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter third number");
        number3 = int.Parse(Console.ReadLine());

        bool isFirstLargest = (number1 > number2 && number1 > number3);
        bool isSecondLargest = (number2 > number1 && number2 > number3);
        bool isThirdLargest = (number3 > number1 && number3 > number2);

        // Displaying output
        Console.WriteLine("Is the first number the largest? "+isFirstLargest);
        Console.WriteLine("Is the second number the largest? "+isSecondLargest);
        Console.WriteLine("Is the third number the largest? "+isThirdLargest);
    }
}
