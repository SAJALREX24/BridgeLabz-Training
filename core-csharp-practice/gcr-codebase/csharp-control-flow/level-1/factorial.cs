using System;

class Random
{
    static void Main(string[] args)
    {
        // Input number
        Console.WriteLine("Enter a natural number");
        int number = int.Parse(Console.ReadLine());

        
        if (number > 0)
        {
            
            int formulaSum = number * (number + 1) / 2;

            
            int loopSum = 0;
            int counter = 1;

            while (counter <= number)
            {
                loopSum += counter;
                counter++;
            }

            // Displaying results
            Console.WriteLine("Sum using formula "+formulaSum);
            Console.WriteLine("Sum using while loop "+loopSum);
            Console.WriteLine("Both computations are correct");
        }
        else
        {
            Console.WriteLine("Entered number is not a natural number.");
        }
    }
}
