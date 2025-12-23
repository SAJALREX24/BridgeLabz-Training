using System;

class Random
{
    static void Main(string[] args)
    {
        // Declaring variables
        int month, day;

        // Taking Input of month and day
        Console.WriteLine("Enter month");
        month = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter day");
        day = int.Parse(Console.ReadLine());

       
        bool isSpring =
            (month == 3 && day >= 20) ||
            (month == 4 || month == 5) ||
            (month == 6 && day <= 20);

        // Output
        if (isSpring)
        {
            Console.WriteLine("Its a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}
