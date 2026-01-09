using System;

class Random
{
    // Check if number is positive
    public static bool IsPositive(int numberValue)
    {
        return numberValue >= 0;
    }

    // Check if number is even
    public static bool IsEven(int numberValue)
    {
        return numberValue % 2 == 0;
    }

    // Compare two numbers
    public static int Compare(int firstValue, int secondValue)
    {
        if (firstValue > secondValue)
            return 1;

        if (firstValue == secondValue)
            return 0;

        return -1;
    }

    static void Main()
    {
        int[] numbersArray = new int[5];

        // Input
        for (int i = 0; i < numbersArray.Length; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbersArray[i] = Convert.ToInt32(Console.ReadLine());

            if (IsPositive(numbersArray[i]))
            {
                if (IsEven(numbersArray[i]))
                    Console.WriteLine("Positive Even");
                else
                    Console.WriteLine("Positive Odd");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }

        // Compare first and last elements
        int compareResultValue = Compare(numbersArray[0], numbersArray[4]);

        if (compareResultValue == 1)
            Console.WriteLine("First > Last");
        else if (compareResultValue == 0)
            Console.WriteLine("First = Last");
        else
            Console.WriteLine("First < Last");
    }
}
