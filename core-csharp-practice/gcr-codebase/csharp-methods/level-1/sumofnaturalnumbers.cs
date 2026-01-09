using System;

class Random
{
    // Method to calculate sum
    public static int CalculatingSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
			sum += i;
        }
		return sum;
    }

    static void Main()
    { 
        // User Input
        Console.Write("Enter n");
        int n = Convert.ToInt32(Console.ReadLine());

        // Method call
        int result = CalculatingSum(n);

        // Displaying Output
        Console.WriteLine("Sum of natural numbers "+ result);
    }
}
