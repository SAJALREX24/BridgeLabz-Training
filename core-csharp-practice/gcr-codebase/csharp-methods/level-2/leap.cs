using System;

class Random
{
    // Method for checking leap year
    public static bool IsLeapYear(int inputYear)
    {
        if (inputYear < 1582)
            return false;

        return (inputYear % 4 == 0 && inputYear % 100 != 0) || (inputYear % 400 == 0);
    }

    static void Main()
    {
        // User Input
        Console.Write("Enter year: ");
        int inputYear = Convert.ToInt32(Console.ReadLine());

        // Displaying Output
        Console.WriteLine(IsLeapYear(inputYear) ? "Leap Year" : "Not a Leap Year");
    }
}
