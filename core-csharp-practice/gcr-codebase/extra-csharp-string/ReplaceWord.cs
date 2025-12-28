using System;

class Random
{
    // Method to replace a word in the given text
    static string Replace(string inputSentence, string targetWord, string replacementWord)
    {
        string finalText = "";
        string currentToken = "";

        for (int index = 0; index < inputSentence.Length; index++)
        {
            if (inputSentence[index] != ' ')
            {
                currentToken += inputSentence[index];
            }
            else
            {
                if (currentToken == targetWord)
                {
                    finalText += replacementWord;
                }
                else
                {
                    finalText += currentToken;
                }

                finalText += " ";
                currentToken = "";
            }
        }

        if (currentToken == targetWord)
        {
            finalText += replacementWord;
        }
        else
        {
            finalText += currentToken;
        }

        return finalText;
    }

    static void Main(string[] args)
    {
        // Taking the input from the user
        string originalText = Console.ReadLine();
        string wordToReplace = Console.ReadLine();
        string newWordValue = Console.ReadLine();

        // Displaying the results
        string outputText = Replace(originalText, wordToReplace, newWordValue);
        Console.WriteLine(outputText);
    }
}
