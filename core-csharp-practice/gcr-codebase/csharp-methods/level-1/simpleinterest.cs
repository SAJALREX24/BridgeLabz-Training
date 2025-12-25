using System;

class Random
{
    // Method to calculate Simple Interest
    public static double Simpleinterest(double principal, double rate, double time)
    {
        // Formula for Simple Interest
        double simpleInterest = (principal * rate * time) / 100;
        return simpleInterest;
    }

    static void Main()
    {
        // Taking input from user
        Console.Write("Enter Principal");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time");
        double time = Convert.ToDouble(Console.ReadLine());

        // Calling method
        double result = Simpleinterest(principal, rate, time);

        // Displaying result
        Console.WriteLine("The Simple Interest is "+result+" for Principal "+principal+", Rate "+rate+" and Time "+time);
    }
}
