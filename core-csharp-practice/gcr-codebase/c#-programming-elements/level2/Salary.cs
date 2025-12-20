using System;

class Random
{
    public static void Main(string[] args)
    {
        //Reading salary from user
        Console.Write("Enter salary");
        double salary = Convert.ToDouble(Console.ReadLine());

        //Reading bonus from user
        Console.Write("Enter bonus");
        double bonus = Convert.ToDouble(Console.ReadLine());

        //Calculating total income
        double totalIncome = salary + bonus;

        //Displaying total income
        Console.WriteLine("The salary is INR "+salary+" and bonus is INR "+bonus+". Hence Total Income is INR "+totalIncome);
    }
}
