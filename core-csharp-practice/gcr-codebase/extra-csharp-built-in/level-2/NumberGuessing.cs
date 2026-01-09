using System;

class Random
{
    // Method to generate number
    static int GenNum()
    {
        Random rnd = new Random();
        return rnd.Next(1, 101);
    }

  
    static void Check(int g, int n)
    {
        if (g < n)
        {
            Console.WriteLine("Low");
        }
        else if (g > n)
        {
            Console.WriteLine("High");
        }
        else
        {
            Console.WriteLine("Correct");
        }
    }

    static void Main(string[] args)
    {
        // Generating the number and initializing guess
        int n = GenNum();
        int g = 0;

        // Displaying the result till the guess is correct
        while (g != n)
        {
            g = int.Parse(Console.ReadLine());
            Check(g, n);
        }
    }
}
