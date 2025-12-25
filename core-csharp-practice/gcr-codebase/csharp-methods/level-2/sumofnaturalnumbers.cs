using System;

class Random
{
    // Recursive method
    public static int RecursiveSum(int inputNumber)
    {
        if (inputNumber == 0)
            return 0;
            return inputNumber + RecursiveSum(inputNumber - 1);
    }

    // Formula method
    public static int FormulaSum(int inputNumber)
    {
        return inputNumber * (inputNumber + 1) / 2;
    }

    static void Main()
    {
        // Input
        Console.Write("Enter a natural number ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());
        if (inputNumber <= 0)
        {
            Console.WriteLine("Not a natural number ");
            return;
        }

        int recursiveResultValue = RecursiveSum(inputNumber);
        int formulaResultValue = FormulaSum(inputNumber);

        // Displaying Output
        Console.WriteLine("Recursive Sum " + recursiveResultValue);
        Console.WriteLine("Formula Sum " + formulaResultValue);
        Console.WriteLine("Results are equal " + (recursiveResultValue == formulaResultValue));
    }
}
