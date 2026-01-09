using System;

class Random
{
    // Method to find all factors of a number
    public static int[] FindFactors(int inputNumber)
    {
        int countValue = 0;
        for (int i = 1; i <= inputNumber; i++)
        {
            if (inputNumber % i == 0)
                countValue++;
        }
        int[] factorsArray = new int[countValue];
        int indexValue = 0;

        for (int i = 1; i <= inputNumber; i++)
        {
            if (inputNumber % i == 0)
                factorsArray[indexValue++] = i;
        }

        return factorsArray;
    }

    
    public static int FindSum(int[] factorsArray)
    {
        int sumValue = 0;

        foreach (int factorValue in factorsArray)
            sumValue += factorValue;

        return sumValue;
    }

   
    public static long FindProduct(int[] factorsArray)
    {
        long productValue = 1;

        foreach (int factorValue in factorsArray)
            productValue *= factorValue;

        return productValue;
    }

    // Method to find sum of squares of factors
    public static double FindSumOfSquares(int[] factorsArray)
    {
        double squareSumValue = 0;

        foreach (int factorValue in factorsArray)
            squareSumValue += Math.Pow(factorValue, 2);

        return squareSumValue;
    }

    static void Main()
    {
        // User Input
        Console.Write("Enter a number ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        // Method calling
        int[] factorsArray = FindFactors(inputNumber);

        // Display factors
        Console.WriteLine("Factors ");
        foreach (int factorValue in factorsArray)
            Console.Write(factorValue + " ");

        Console.WriteLine("\nSum of Factors " + FindSum(factorsArray));
        Console.WriteLine("Product of Factors " + FindProduct(factorsArray));
        Console.WriteLine("Sum of Squares of Factors " + FindSumOfSquares(factorsArray));
    }
}
