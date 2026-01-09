using System;

class Random
{
    // Method to compare two strings lexicographically
    static int EvaluateOrder(string textA, string textB)
    {
        
        int minLength = textA.Length < textB.Length ? textA.Length : textB.Length;

       
        for (int position = 0; position < minLength; position++)
        {
            if (textA[position] < textB[position])
            {
                return -1;
            }
            else if (textA[position] > textB[position])
            {
                return 1;
            }
        }

       
        if (textA.Length < textB.Length)
        {
            return -1;
        }
        else if (textA.Length > textB.Length)
        {
            return 1;
        }

        return 0;
    }

    static void Main(string[] args)
    {
        // Reading input from the user
        string inputOne = Console.ReadLine();
        string inputTwo = Console.ReadLine();

        // Comparing the strings
        int comparisonResult = EvaluateOrder(inputOne, inputTwo);

        // Displaying the result
        if (comparisonResult < 0)
        {
            Console.WriteLine(inputOne + " comes before " + inputTwo + " in lexicographical order");
        }
        else if (comparisonResult > 0)
        {
            Console.WriteLine(inputOne + " comes after " + inputTwo + " in lexicographical order");
        }
        else
        {
            Console.WriteLine("Both strings are equal");
        }
    }
}
