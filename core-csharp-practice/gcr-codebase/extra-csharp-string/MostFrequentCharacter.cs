using System;

class Random
{
    // Method to find most frequent character
    static char FindMostFrequent(string inputText)
    {
        int highestFrequency = 0;
        char mostCommonChar = ' ';

        for (int outerIndex = 0; outerIndex < inputText.Length; outerIndex++)
        {
            int currentCount = 0;

            for (int innerIndex = 0; innerIndex < inputText.Length; innerIndex++)
            {
                if (inputText[outerIndex] == inputText[innerIndex])
                {
                    currentCount++;
                }
            }

            if (currentCount > highestFrequency)
            {
                highestFrequency = currentCount;
                mostCommonChar = inputText[outerIndex];
            }
        }

        return mostCommonChar;
    }

    static void Main(string[] args)
    {
        // Taking the input from the user
        string userInput = Console.ReadLine();

        // Displaying the results
        char finalResult = FindMostFrequent(userInput);
        Console.WriteLine(finalResult);
    }
}
