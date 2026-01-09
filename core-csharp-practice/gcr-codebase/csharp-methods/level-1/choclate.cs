using System;

class Random
{
    public static int[] FindRandq(int number, int divisor)
    {
        int quotient = number / divisor;
        int remainder = number % divisor;

        return new int[] { quotient, remainder };
    }

    static void Main()
    {
        // Inputs
        Console.Write("Enter number");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter divisor");
        int divisor = Convert.ToInt32(Console.ReadLine());

        // Method call
        int[] result = FindRandq(number, divisor);

        // Output
        Console.WriteLine("Quotient " + result[0]);
        Console.WriteLine("Remainder " + result[1]);
    }
}
