using System;

class Random
{
    // Method to count occurrences of a substring
    static int CountSubstring(string txt, string sub)
    {
        int cnt = 0;

        for (int i = 0; i <= txt.Length - sub.Length; i++)
        {
            int m = 0;

            for (int j = 0; j < sub.Length; j++)
            {
                if (txt[i + j] == sub[j])
                {
                    m++;
                }
            }

            if (m == sub.Length)
            {
                cnt++;
            }
        }

        return cnt;
    }

    static void Main(string[] args)
    {
        // Taking the input of string and substring from the user
        string txt = Console.ReadLine();
        string sub = Console.ReadLine();

        // Displaying the results
        int res = CountSubstring(txt, sub);
        Console.WriteLine(res);
    }
}
