using System;

class Random
{
    // Method for checking spring season
    public static bool Springchecker(int month, int day)
    {
        return (month == 3 && day >= 20) ||
               (month == 4) ||
               (month == 5) ||
               (month == 6 && day <= 20);
    }

    static void Main(string[] args)
    {
        int month = Convert.ToInt32(args[0]);
        int day = Convert.ToInt32(args[1]);

        // Method call
        bool result = Springchecker(month, day);

        // Displaying Output
        Console.WriteLine(result ? "Its a Spring Season" : "Not a Spring Season");
    }
}
