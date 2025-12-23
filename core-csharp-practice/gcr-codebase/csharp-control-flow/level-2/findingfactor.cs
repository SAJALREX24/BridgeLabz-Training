using System;

class Random
{
    static void Main(string[] args)
    {
        // User Input 
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());

        
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
