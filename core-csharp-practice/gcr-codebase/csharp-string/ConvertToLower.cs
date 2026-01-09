using System;

class Random
{
    // Method to convert to lowercase
    static string ToLower(string s)
    {
        string res = "";

        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            if (ch >= 'A' && ch <= 'Z')
            {
                ch = (char)(ch + 32);
            }
            res += ch;
        }

        return res;
    }

    static void Main(string[] args)
    {
        // Taking the input from the user
        string s = Console.ReadLine();

        string res = ToLower(s);

        // Displaying the result
        Console.WriteLine(res);

        // Built-in method
        Console.WriteLine(s.ToLower());
    }
}
