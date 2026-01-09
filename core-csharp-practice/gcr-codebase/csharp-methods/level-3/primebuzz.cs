using System;

class Random
{
    // Method to check whether a number is Prime
    public static bool IsPrime(int inputNumber)
    {
        if (inputNumber <= 1)
            return false;

        // Checking divisibility up to square root of number
        for (int divisor = 2; divisor <= Math.Sqrt(inputNumber); divisor++)
        {
            if (inputNumber % divisor == 0)
                return false;
        }

        return true;
    }

    // Method to check Neon number
    public static bool IsNeon(int inputNumber)
    {
        int squareValue = inputNumber * inputNumber;
        int sumValue = 0;
        while (squareValue > 0)
        {
            sumValue += squareValue % 10;
            squareValue /= 10;
        }

        return sumValue == inputNumber;
    }

    // check Spy number
    public static bool IsSpy(int inputNumber)
    {
        int sumValue = 0;
        int productValue = 1;

        // Calculate sum and product of digits
        while (inputNumber > 0)
        {
            int digitValue = inputNumber % 10;
            sumValue += digitValue;
            productValue *= digitValue;
            inputNumber /= 10;
        }

        return sumValue == productValue;
    }

    // Method to check Automorphic number
    public static bool IsAutomorphic(int inputNumber)
    {
        int squareValue = inputNumber * inputNumber;

        // Check if square ends with the number
        return squareValue.ToString().EndsWith(inputNumber.ToString());
    }

    // Method to check Buzz number
    public static bool IsBuzz(int inputNumber)
    {
        // Buzz number is divisible by 7 or ends with 7
        return inputNumber % 7 == 0 || inputNumber % 10 == 7;
    }

    static void Main()
    {
        // User Input
        Console.Write("Enter a number ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        // Output results
        Console.WriteLine("Prime: " + IsPrime(inputNumber));
        Console.WriteLine("Neon: " + IsNeon(inputNumber));
        Console.WriteLine("Spy: " + IsSpy(inputNumber));
        Console.WriteLine("Automorphic: " + IsAutomorphic(inputNumber));
        Console.WriteLine("Buzz: " + IsBuzz(inputNumber));
    }
}
