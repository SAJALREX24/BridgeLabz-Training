using System;

class Random
{
    // Method to calculate sum of heights
    public static int FindSum(int[] heightsArray)
    {
        int sumValue = 0;
        foreach (int heightValue in heightsArray)
            sumValue += heightValue;

        return sumValue;
    }

    
    public static double FindMean(int[] heightsArray)
    {
        
        return (double)FindSum(heightsArray) / heightsArray.Length;
    }

    // Method to find shortest height
    public static int FindShortest(int[] heightsArray)
    {
        int minValue = heightsArray[0];

        // Find minimum height
        foreach (int heightValue in heightsArray)
        {
            if (heightValue < minValue)
                minValue = heightValue;
        }

        return minValue;
    }

   
    public static int FindTallest(int[] heightsArray)
    {
        int maxValue = heightsArray[0];

        
        foreach (int heightValue in heightsArray)
        {
            if (heightValue > maxValue)
                maxValue = heightValue;
        }

        return maxValue;
    }

    static void Main()
    {
    
        int[] heightsArray = new int[11];

        
        System.Random randomObject = new System.Random();

        
        for (int index = 0; index < heightsArray.Length; index++)
        {
            heightsArray[index] = randomObject.Next(150, 251);
        }

        
        Console.WriteLine("Player Heights");
        foreach (int heightValue in heightsArray)
            Console.Write(heightValue + " ");

        Console.WriteLine();

        // Display results
        Console.WriteLine("Shortest Height " + FindShortest(heightsArray));
        Console.WriteLine("Tallest Height " + FindTallest(heightsArray));
        Console.WriteLine("Mean Height " + FindMean(heightsArray));
    }
}
