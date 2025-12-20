using System;

class Random
{
    public static void Main(string[] args)
    {
        //Reading principal amount
        Console.Write("Enter Principal");
        double principal = Convert.ToDouble(Console.ReadLine());

        //Reading rate of interest
        Console.Write("Enter Rate");
        double rate = Convert.ToDouble(Console.ReadLine());

        //Reading time period
        Console.Write("Enter Time");
        double time = Convert.ToDouble(Console.ReadLine());

        //Calculating simple interest
        double simpleInterest = (principal * rate * time) / 100;

        //Displaying result
        Console.WriteLine("The Simple Interest is "+simpleInterest+" for Principal "+principal+", Rate of Interest "+rate+" and Time "+time);
    }
}
