using System;

class MultiplesBelowHundred
{
    static void Main(string[] args)
    {
        // User Input 
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());

        
        for (int i = 100; i >= 1; i--)
        {
            if (i % number == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
