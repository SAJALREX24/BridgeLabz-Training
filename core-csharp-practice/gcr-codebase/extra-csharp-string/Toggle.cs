using System;

class Random
{
    // Method to toggle case
    static string Toggle(string txt)
    {
        string res = "";

        for (int i = 0; i < txt.Length; i++)
        {
            char ch = txt[i];

            if (ch >= 'a' && ch <= 'z')
            {
                ch = (char)(ch - 32);
            }
            else if (ch >= 'A' && ch <= 'Z')
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
        string txt = Console.ReadLine();

        // Displaying the results
        string res = Toggle(txt);
        Console.WriteLine(res);
    }
}
