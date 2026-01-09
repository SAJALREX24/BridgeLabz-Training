using System;

class Random
{
    // Method for vowels counting
    static int Vowels(string s)
    {
        int v = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
            {
                v++;
            }
        }

        return v;
    }

    // Method for consonants counting
    static int Consonants(string s)
    {
        int c = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != 'a' && s[i] != 'e' && s[i] != 'i' && s[i] != 'o' && s[i] != 'u')
            {
                c++;
            }
        }

        return c;
    }

    static void Main(string[] args)
    {
        // Taking the string from the user
        string s = Console.ReadLine();

        // Giving the values to the functions and displaying the result
        Console.WriteLine("Vowels are: " + Vowels(s));
        Console.WriteLine("Consonants are: " + Consonants(s));
    }
}
