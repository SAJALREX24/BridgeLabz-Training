using System;

class Random
{
    // Method to remove duplicate characters
    static string Remove(string inputText)
    {
        string uniqueResult = "";

        for (int index = 0; index < inputText.Length; index++)
        {
            bool isDuplicate = false;

            for (int checkIndex = 0; checkIndex < uniqueResult.Length; checkIndex++)
            {
                if (inputText[index] == uniqueResult[checkIndex])
                {
                    isDuplicate = true;
                }
            }

            if (isDuplicate == false)
            {
                uniqueResult += inputText[index];
            }
        }

        return uniqueResult;
    }

    static void Main(string[] args)
    {
        // Taking the input from the user
        string userInput = Console.ReadLine();

        // Displaying the result
        string finalOutput = Remove(userInput);
        Console.WriteLine(finalOutput);
    }
}
