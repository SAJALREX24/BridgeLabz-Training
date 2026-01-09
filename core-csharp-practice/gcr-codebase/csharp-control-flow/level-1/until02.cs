using System;

class Random
{
    static void Main(string[] args)
    {
        // Initializing total
        double total = 0.0;

        
        while (true)
        {
            Console.WriteLine("Enter a number");
            double number = double.Parse(Console.ReadLine());

            // Break condition
            if (number <= 0)
            {
                break;
            }

            total += number;
        }

        // Displaying result
        Console.WriteLine("Total sum is "+total);
    }
}
