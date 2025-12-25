using System;

class Random
{
    // Method to generate an array of 4-digit random numbers
    public static int[] Generate4DigitRandomArray(int arraySize)
    {
        // Create Random object (fully qualified to avoid name conflict)
        System.Random randomObject = new System.Random();

        // Declare array to store numbers
        int[] numbersArray = new int[arraySize];

        // Generate random 4-digit numbers
        for (int index = 0; index < arraySize; index++)
        {
            numbersArray[index] = randomObject.Next(1000, 10000);
        }

        return numbersArray;
    }

    // Method to find average, minimum, and maximum
    public static double[] FindAverageMinMax(int[] numbersArray)
    {
        // Initialize variables
        int minValue = numbersArray[0];
        int maxValue = numbersArray[0];
        int sumValue = 0;

        // Loop through array elements
        foreach (int currentValue in numbersArray)
        {
            sumValue += currentValue;

            // Find minimum value
            if (currentValue < minValue)
                minValue = currentValue;

            // Find maximum value
            if (currentValue > maxValue)
                maxValue = currentValue;
        }

        // Calculate average
        double averageValue = sumValue / (double)numbersArray.Length;

        // Return results as array
        return new double[] { averageValue, minValue, maxValue };
    }

    static void Main()
    {
        // Generate random numbers
        int[] numbersArray = Generate4DigitRandomArray(5);

        // Display generated numbers
        Console.WriteLine("Generated Numbers:");
        foreach (int value in numbersArray)
            Console.Write(value + " ");

        Console.WriteLine();

        // Find average, min, and max
        double[] resultArray = FindAverageMinMax(numbersArray);

        // Display results
        Console.WriteLine("Average: " + resultArray[0]);
        Console.WriteLine("Minimum: " + resultArray[1]);
        Console.WriteLine("Maximum: " + resultArray[2]);
    }
}
