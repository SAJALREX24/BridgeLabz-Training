using System;

class Random
{
    static void Main(string[] args)
    {
        // Input ages
        Console.WriteLine("Enter Amar's age");
        int amarAge = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Akbar's age");
        int akbarAge = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Anthony's age");
        int anthonyAge = int.Parse(Console.ReadLine());

        // Input heights
        Console.WriteLine("Enter Amar's height");
        double amarHeight = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Akbar's height");
        double akbarHeight = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Anthony's height");
        double anthonyHeight = double.Parse(Console.ReadLine());

        // Finding youngest age
        int youngestAge = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));

        // Finding tallest height
        double tallestHeight = Math.Max(amarHeight, Math.Max(akbarHeight, anthonyHeight));

        // Displaying results
        Console.WriteLine("Youngest age is "+youngestAge);
        Console.WriteLine("Tallest height is "+tallestHeight);
    }
}
