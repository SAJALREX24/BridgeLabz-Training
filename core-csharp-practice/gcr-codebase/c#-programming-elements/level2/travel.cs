using System;

class Random
{
    public static void Main(string[] args)
    {
        //Reading traveler details
        Console.Write("Enter traveler name");
        string name = Console.ReadLine();

        Console.Write("Enter From City");
        string fromCity = Console.ReadLine();

        Console.Write("Enter Via City");
        string viaCity = Console.ReadLine();

        Console.Write("Enter To City");
        string toCity = Console.ReadLine();

        //Reading distance details
        Console.Write("Enter distance from FromCity to ViaCity");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter distance from ViaCity to ToCity");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        //Reading time taken
        Console.Write("Enter total time taken");
        int timeTaken = Convert.ToInt32(Console.ReadLine());

        //Calculating total distance
        double totalDistance = fromToVia + viaToFinalCity;

        //Displaying trip summary
        Console.WriteLine("The results of the trip are "+totalDistance+" distance and "+timeTaken+" minutes travelled by "+name+" from "+fromCity+" to "+toCity+" via "+viaCity);
    }
}
