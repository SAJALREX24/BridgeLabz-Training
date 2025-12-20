using System;

class Random
{
    public static void Main(string[] args)
    {
        //Reading number of chocolates
        Console.Write("Enter number of chocolates");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        //Reading number of children
        Console.Write("Enter number of children");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        //Calculating chocolates each child gets
        int chocolatesEach = numberOfChocolates / numberOfChildren;

        //Calculating remaining chocolates
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        //Displaying result
        Console.WriteLine("The number of chocolates each child gets is "+chocolatesEach+" and the number of remaining chocolates is "+remainingChocolates);
    }
}
