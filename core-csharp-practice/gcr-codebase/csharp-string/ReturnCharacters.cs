using System;

class Random
{
    // Method to return characters
    static char[] GetChars(string s)
    {
        char[] res = new char[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            res[i] = s[i];
        }
        }

        return res;
    }

    static void Main(string[] args)
    {
        // Taking input
        string s = Console.ReadLine();

        // Custom method
        char[] res = GetChars(s);
        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine(res[i]);
        }

        // Built-in method
        char[] arr = s.ToCharArray();
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
