using System;

class Random
{
    public static void Main(string[] args)
    {
        //Reading double values from user
        Console.Write("Enter value of a");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value of b");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value of c");
        double c = Convert.ToDouble(Console.ReadLine());

        //Performing double operations
        double result1 = a + b * c;
        double result2 = a * b + c;
        double result3 = c + a / b;
        double result4 = a % b + c;

        //Displaying results
        Console.WriteLine("The results of Double Operations are "+result1+", "+result2+", "+result3+", and "+result4);
    }
}
