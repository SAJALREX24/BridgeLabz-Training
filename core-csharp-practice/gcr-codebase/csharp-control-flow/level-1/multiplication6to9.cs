using System;

class Random
{
    static void Main()
    {
        // Taking  input
        Console.WriteLine("Enter a number");
        int number = int.Parse(Console.ReadLine());

        // Loop from 6 to 9 for multiplication
        for (int i = 6; i <= 9; i++)
        {
            // Printing multiplication result
            Console.WriteLine(number+" * "+i+" = "+(number * i));
        }
    }
}
