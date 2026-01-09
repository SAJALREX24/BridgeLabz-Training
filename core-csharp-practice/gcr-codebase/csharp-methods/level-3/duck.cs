using System;

class Random
{
    // Count digits
    public static int CountDigits(int number)
    {
        int count = 0;
        while (number > 0)
        {
            count++;
            number /= 10;
        }
        return count;
    }

    public static int[] GetDigits(int number)
    {
        int count = CountDigits(number);
        int[] digits = new int[count];

        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    // Check Duck Number
    public static bool IsDuckNumber(int[] digits)
    {
        foreach (int d in digits)
            if (d != 0)
                return true;
        return false;
    }

    // Check Armstrong Number
    public static bool IsArmstrong(int number, int[] digits)
    {
        int power = digits.Length;
        int sum = 0;

        foreach (int d in digits)
            sum += (int)Math.Pow(d, power);

        return sum == number;
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] digits = GetDigits(number);

        Console.WriteLine("Duck Number: " + IsDuckNumber(digits));
        Console.WriteLine("Armstrong Number: " + IsArmstrong(number, digits));
    }
}
