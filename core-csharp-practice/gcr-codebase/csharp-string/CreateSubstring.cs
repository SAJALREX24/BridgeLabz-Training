using System;

class Random
{
    // Method to create substring
    static string Sub(string s, int st, int en)
    {
        string res = "";

        for (int i = st; i <= en; i++)
        {
            res += s[i];
        }
        }

        return res;
    }

    static void Main(string[] args)
    {
        // Taking input
        string s = Console.ReadLine();
        int st = int.Parse(Console.ReadLine());
        int en = int.Parse(Console.ReadLine());

        // Calling method
        string res = Sub(s, st, en);
        Console.WriteLine(res);

        // Built-in substring
        Console.WriteLine(s.Substring(st, (en - st) + 1));
    }
}
