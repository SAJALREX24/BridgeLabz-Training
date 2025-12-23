using System;

class Random
{
    static void Main(string[] args)
    {
        // Declaring variables
        double total = 0.0;
        double value;

        // Input loop
        while (true)
        {
            Console.WriteLine("Enter a number");
            value = double.Parse(Console.ReadLine());

            
            if (value == 0)
            {
                break;
            }

           
            total += value;
        }

        // Displaying sum
        Console.WriteLine("Total sum is "+total);
    }
}
