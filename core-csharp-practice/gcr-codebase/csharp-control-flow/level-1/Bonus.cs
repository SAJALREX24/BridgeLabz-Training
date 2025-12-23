using System;

class Random
{
    static void Main()
    {
        // enter salary
        Console.WriteLine("Enter employee salary");
        double salary = double.Parse(Console.ReadLine());

        // enter years of service
        Console.WriteLine("Enter years of service");
        int yearsOfService = int.Parse(Console.ReadLine());

        // Initializing bonus variable
        double bonusAmount = 0.0;

        // Checking eligibility for bonus
        if (yearsOfService > 5)
        {
            // Calculating 5% bonus
            bonusAmount = salary * 0.05;
        }

        // Displaying bonus amount
	Console.WriteLine("The bonus amount is "+bonusAmount);
    }
}
