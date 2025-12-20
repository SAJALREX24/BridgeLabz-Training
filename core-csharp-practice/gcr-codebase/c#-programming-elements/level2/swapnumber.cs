using System;

class Random
{
    public static void Main(string[] args)
    {
        //Reading first number
        Console.Write("Enter first number");
        int number1 = Convert.ToInt32(Console.ReadLine());

        //Reading second number
        Console.Write("Enter second number");
        int number2 = Convert.ToInt32(Console.ReadLine());

        //Using temporary variable to swap values
        int temp = number1;
        number1 = number2;
        number2 = temp;

        //Displaying swapped numbers
        Console.WriteLine("The swapped numbers are "+number1+" and "+number2);
    }
}
