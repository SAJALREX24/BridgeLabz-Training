using System;

class Random
{
    public static int[] FindSandl(int number1, int number2, int number3)
    {
        int smallest = Math.Min(number1, Math.Min(number2, number3));
        int largest = Math.Max(number1, Math.Max(number2, number3));

        return new int[] { smallest, largest };
    }

    static void Main()
    {
        // Inputs
        Console.Write("Enter number 1");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number 2");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number 3");
        int c = Convert.ToInt32(Console.ReadLine());

        // Method call
        int[] result = FindSandl(a, b, c);

        // Output
        Console.WriteLine("Smallest " + result[0]);
        Console.WriteLine("Largest " + result[1]);
    }
}
