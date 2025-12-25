using System;

class Random
{
    // Method to find all factors of a number
    public static int[] FindFactors(int inputNumber)
    {
        int countValue = 0;

       
        for (int divisor = 1; divisor <= inputNumber; divisor++)
        {
            if (inputNumber % divisor == 0)
                countValue++;
        }
        int[] factorsArray = new int[countValue];
        int indexValue = 0;
        for (int divisor = 1; divisor <= inputNumber; divisor++)
        {
            if (inputNumber % divisor == 0)
                factorsArray[indexValue++] = divisor;
        }

        return factorsArray;
    }

    
    public static bool IsPerfect(int inputNumber, int[] factorsArray)
    {
        int sumValue = 0;

        // Add all factors except the number itself
        foreach (int factorValue in factorsArray)
        {
            if (factorValue != inputNumber)
                sumValue += factorValue;
        }

        return sumValue == inputNumber;
    }

    static void Main()
    {
        // User Input
        Console.Write("Enter a number: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        int[] factorsArray = FindFactors(inputNumber);

        // Displaying factors
        Console.WriteLine("Factors:");
        foreach (int factorValue in factorsArray)
            Console.Write(factorValue + " ");

        Console.WriteLine();

        // Check perfect number
        if (IsPerfect(inputNumber, factorsArray))
            Console.WriteLine("Perfect Number");
        else
            Console.WriteLine("NOT a Perfect Number");
    }
}
