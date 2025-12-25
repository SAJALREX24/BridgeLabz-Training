using System;

class Random
{
    
    public static double CalculateBonus(double salaryAmount, int yearsOfService)
    {
        // If years of service is greater than 5, give 5% bonus
        // Otherwise, give 2% bonus
        return yearsOfService > 5? salaryAmount * 0.05: salaryAmount * 0.02;
    }

    static void Main()
    {
     
        Console.Write("Enter Employee Salary");
        double salaryAmount = Convert.ToDouble(Console.ReadLine());

       
        Console.Write("Enter Years of Service");
        int yearsOfService = Convert.ToInt32(Console.ReadLine());

       
        double bonusAmount = CalculateBonus(salaryAmount, yearsOfService);

        // Display the bonus
        Console.WriteLine("Employee Bonus Amount is: " + bonusAmount);
    }
}

