using System;

class Random
{
    // Method to check whether two strings are anagrams
    static bool CheckAnagram(string textOne, string textTwo)
    {
       
        if (textOne.Length != textTwo.Length)
        {
            return false;
        }

      
        int[] frequencyA = new int[256];
        int[] frequencyB = new int[256];

        // Count character occurrences
        for (int index = 0; index < textOne.Length; index++)
        {
            frequencyA[textOne[index]]++;
            frequencyB[textTwo[index]]++;
        }

      
        for (int ascii = 0; ascii < 256; ascii++)
        {
            if (frequencyA[ascii] != frequencyB[ascii])
            {
                return false;
            }
        }

        return true;
    }

    static void Main(string[] args)
    {
        // Reading input strings
        string inputOne = Console.ReadLine();
        string inputTwo = Console.ReadLine();

     
        bool isAnagram = CheckAnagram(inputOne, inputTwo);

        // Displaying the result
        Console.WriteLine(isAnagram);
    }
}
