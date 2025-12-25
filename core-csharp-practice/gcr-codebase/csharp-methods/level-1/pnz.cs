using System;

class Random
{
    // Method for checking number
    public static int CheckingNumber(int number)
    {
        if (number > 0)
            return 1;
        else if (number < 0)
            return -1;
        else
            return 0;
    }

    static void Main()
    {
        // User Input
        Console.Write("Enter a number");
        int number = Convert.ToInt32(Console.ReadLine());

        // Method call
        int result = CheckingNumber(number);

        // Displaying Output
        Console.WriteLine("Result" + result);
    }
}
