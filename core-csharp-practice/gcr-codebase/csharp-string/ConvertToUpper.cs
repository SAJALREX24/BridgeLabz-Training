using System;

class Random
{
    // Method to convert to uppercase
    static string ToUpper(string s)
    {
        string res = "";

        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            if (ch >= 'a' && ch <= 'z')
            {
                ch = (char)(ch - 32);
            }
            res += ch;
        }

        return res;
    }

    static void Main(string[] args)
    {
        // Taking the input from the user
        string s = Console.ReadLine();

        string res = ToUpper(s);

        // Display the results
        Console.WriteLine(res);

        // Built-in method
        Console.WriteLine(s.ToUpper());
    }
}
