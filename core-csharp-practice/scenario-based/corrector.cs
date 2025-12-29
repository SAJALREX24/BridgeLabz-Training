/*Strings – Sentence Formatter
1. Scenario: A text editing tool receives poorly formatted input from users. Your task is to auto-correct formatting by fixing spacing and capitalizing the first letter of each sentence.
Problem:
Write a method that takes a paragraph as input and returns a corrected version with:
● One space after punctuation,
● Capital letter after period/question/exclamation marks,
● Trimmed extra spaces.

2. Scenario: Create a program that analyzes a given paragraph of text. Implement the following
functionalities:
● Count the number of words in the paragraph.
● Find and display the longest word.
● Replace all occurrences of a specific word with another word (case-insensitive).
● Handle edge cases like empty strings or paragraphs with only spaces.

*/
using System;

class StringFormatter
{
	
	
	 // Adds one space after punctuation
    static string OneSpaceAfterPunctuation(string input)
    {
        string formattedText = "";

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '.' || input[i] == ',' || input[i] == '?' ||input[i] == '!' || input[i] == ':' || input[i] == ';')
            {
                formattedText += input[i] + " ";
            }
            else
            {
                formattedText += input[i];
            }
        }
        return formattedText;
    }

    // Capitalizes first letter after '.', '!' or '?'
    static string CapitalLetter(string input)
    {
        string resultText = "";

        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == '.' || input[i] == '!' || input[i] == '?')
            {
                resultText += input[i];
                resultText += (char)(input[i + 1] - 32);
                i++;
            }
            else
            {
                resultText += input[i];
            }
        }

        resultText += input[input.Length - 1];
        return resultText;
    }

    // Removes extra spaces
    static string ExtraSpace(string input)
    {
        string cleanText = "";

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ' && input[i + 1] == ' ')
            {
                cleanText += ' ';
                i++;
            }
            else
            {
                cleanText += input[i];
            }
        }
        return cleanText;
    }
    // Counts number of words in the text
    static int CountWords(string text)
    {
        int wordCount = 0;

        for (int i = 0; i < text.Length; i++)
        {
            
            if (text[i] != ' ' && (i == 0 || text[i - 1] == ' '))
            {
                wordCount++;
            }
        }
        return wordCount;
    }

    // Finds the longest word in the text
    static string FindLongestWord(string text)
    {
        string longestWord = "";
        string currentWord = "";

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != ' ')
            {
                currentWord += text[i];
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

        // Check last word
        if (currentWord.Length > longestWord.Length)
            longestWord = currentWord;

        return longestWord;
    }

    // Replaces a word with another word
    static string ReplaceWord(string text, string oldWord, string newWord)
    {
        string resultText = "";
        string tempWord = "";

        for (int i = 0; i <= text.Length; i++)
        {
            if (i < text.Length && text[i] != ' ')
            {
                tempWord += text[i];
            }
            else
            {
                if (tempWord == oldWord)
                    resultText += newWord;
                else
                    resultText += tempWord;

                if (i < text.Length)
                    resultText += " ";

                tempWord = "";
            }
        }
        return resultText;
    }

   

    // Main method
    static void Main(string[] args)
    {

        int choice = int.Parse(Console.ReadLine());
		Console.Write("Press 1 for string formating");
		Console.WriteLine("Press 2 for string ")

        switch (choice)
        {
            case 1:
               
                string inputText = Console.ReadLine();
				
               
                string capitalText = CapitalLetter(inputText);
                string spacedText = OneSpaceAfterPunctuation(capitalText);

                Console.WriteLine(ExtraSpace(spacedText));
                break;

            case 2:
               
                string paragraph = Console.ReadLine();

                Console.WriteLine( paragraph);
                Console.WriteLine(CountWords(paragraph));
                Console.WriteLine(FindLongestWord(paragraph));

               
                
                string newWord = Console.ReadLine();

                Console.WriteLine("Enter the old word");
                string oldWord = Console.ReadLine();

                Console.WriteLine(ReplaceWord(paragraph, oldWord, newWord));
                break;
        }
    }
}
