using System;

class Random
{
    // Method to find longest word
    static string FindLongest(string inputSentence)
    {
        string currentWord = "";
        string longestWord = "";

        for (int index = 0; index < inputSentence.Length; index++)
        {
            if (inputSentence[index] != ' ')
            {
                currentWord += inputSentence[index];
            }
            else
            {
                if (currentWord.Length > longestWord.Length)
                {
                    longestWord = currentWord;
                }
                currentWord = "";
            }
        }

        if (currentWord.Length > longestWord.Length)
        {
            longestWord = currentWord;
        }

        return longestWord;
    }

    static void Main(string[] args)
    {
        // Taking the input from the user
        string userInput = Console.ReadLine();

        // Displaying the results
        string finalResult = FindLongest(userInput);
        Console.WriteLine(finalResult);
    }
}
