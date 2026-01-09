using System;

class Random
{
    public static void Main(string[] args)
    {
        //Reading sides of triangular park
        Console.Write("Enter side1");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side2");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side3");
        double side3 = Convert.ToDouble(Console.ReadLine());

        //Calculating perimeter
        double perimeter = side1 + side2 + side3;

        //Total distance athlete wants to run 
        double totalDistance = 5000;

        //Calculating number of rounds
        double rounds = totalDistance / perimeter;

        //Displaying result
        Console.WriteLine("The total number of rounds the athlete will run is "+rounds);
		
    }
}
