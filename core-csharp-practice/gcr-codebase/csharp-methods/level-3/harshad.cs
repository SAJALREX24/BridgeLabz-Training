using System;

class Random
{
    // Method for calculating sum of digits
    public static int SumOfDigits(int[] digitsArray)
    {
        int sumValue = 0;
        foreach (int digitValue in digitsArray)
            sumValue += digitValue;

        return sumValue;
    }
    public static bool IsHarshad(int inputNumber, int[] digitsArray)
    {
        
        return inputNumber % SumOfDigits(digitsArray) == 0;
    }

    // Method to find frequency of digits
    public static int[,] FindFrequency(int[] digitsArray)
    {
       
        int[,] frequencyArray = new int[10, 2];

        
        for (int index = 0; index < 10; index++)
            frequencyArray[index, 0] = index;

        
        foreach (int digitValue in digitsArray)
            frequencyArray[digitValue, 1]++;

        return frequencyArray;
    }

    
    public static int[] ExtractDigits(int inputNumber)
    {
        int tempNumber = inputNumber;
        int countValue = 0;

        // Count number of digits
        while (tempNumber > 0)
        {
            countValue++;
            tempNumber /= 10;
        }

        int[] digitsArray = new int[countValue];
        tempNumber = inputNumber;

        // Store digits in array
        for (int index = countValue - 1; index >= 0; index--)
        {
            digitsArray[index] = tempNumber % 10;
            tempNumber /= 10;
        }

        return digitsArray;
    }

    static void Main()
    {
        // User Input
        Console.Write("Enter a number ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        // Extract digits
        int[] digitsArray = ExtractDigits(inputNumber);

        // Check Harshad number
        if (IsHarshad(inputNumber, digitsArray))
            Console.WriteLine("Harshad Number");
        else
            Console.WriteLine("NOT a Harshad Number");

        // Find digit frequency
        int[,] frequencyArray = FindFrequency(digitsArray);

        // Display digit frequencies
        Console.WriteLine("Digit Frequency ");
        for (int index = 0; index < 10; index++)
        {
            if (frequencyArray[index, 1] > 0)
                Console.WriteLine("Digit " + frequencyArray[index, 0] +" -> " + frequencyArray[index, 1] + " time(s)");
        }
    }
}
