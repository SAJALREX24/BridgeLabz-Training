using System;

class Random
{
    // Method to reverse an integer array
    public static int[] ReverseArray(int[] digitsArray)
    {
        int[] reversedArray = new int[digitsArray.Length];

        // Reverse the array
        for (int index = 0; index < digitsArray.Length; index++)
        {
            reversedArray[index] = digitsArray[digitsArray.Length - index - 1];
        }

        return reversedArray;
    }

    
    public static bool AreEqual(int[] firstArray, int[] secondArray)
    {
        for (int index = 0; index < firstArray.Length; index++)
        {
            if (firstArray[index] != secondArray[index])
                return false;
        }

        return true;
    }

    // Helper method to extract digits from a number
    public static int[] ExtractDigits(int inputNumber)
    {
        int tempNumber = inputNumber;
        int countValue = 0;

        // Count digits
        while (tempNumber > 0)
        {
            countValue++;
            tempNumber /= 10;
        }

        int[] digitsArray = new int[countValue];
        tempNumber = inputNumber;

        
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

        // Reverse digits
        int[] reversedArray = ReverseArray(digitsArray);

        // Check palindrome
        if (AreEqual(digitsArray, reversedArray))
            Console.WriteLine("Palindrome Number");
        else
            Console.WriteLine("NOT a Palindrome Number");
    }
}
