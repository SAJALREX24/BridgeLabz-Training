using System;

class Random
{
    static void Main(string[] args)
    {
        // Input number
        Console.WriteLine("Enter a natural number");
        int number = int.Parse(Console.ReadLine());

        // Validating natural number
        if (number > 0)
        {
          
            for (int i = 1; i <= number; i++)
            {
                
                if (i % 2 == 0)
                {
                    Console.WriteLine(i+" is an Even number");
                }
                else
                {
                    Console.WriteLine(i+" is an Odd number");
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a natural number");
        }
    }
}
