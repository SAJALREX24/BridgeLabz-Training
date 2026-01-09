using System;

class Random
{
    static void Main(string[] args)
    {
        // Declaring counter variable
        int counter;

        // Taking input
        Console.WriteLine("Enter countdown start value");
        counter = int.Parse(Console.ReadLine());

       
        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }

        Console.WriteLine("Launch");
    }
}
