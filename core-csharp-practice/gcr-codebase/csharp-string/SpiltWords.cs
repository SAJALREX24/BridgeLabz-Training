using System;

class Random
{
    // Method to calculate length without Length
    static int Len(string s)
    {
        int cnt = 0;
        foreach (char c in s)
        {
            cnt++;
        }
        return cnt;
    }

    // Method to split words
    static string[,] Split(string txt)
    {
        string[,] res = new string[100, 2];
        string w = "";
        int idx = 0;

        for (int i = 0; i < txt.Length; i++)
        {
            if (txt[i] != ' ')
            {
                w += txt[i];
            }
            else
            {
                res[idx, 0] = w;
                res[idx, 1] = Len(w).ToString();
                idx++;
                w = "";
            }
        }

        res[idx, 0] = w;
        res[idx, 1] = Len(w).ToString();

        return res;
    }

    static void Main(string[] args)
    {
        // Taking the input from the user
        string txt = Console.ReadLine();

        string[,] res = Split(txt);

        // Displaying the results
        for (int i = 0; i < res.GetLength(0); i++)
        {
            if (res[i, 0] != null)
            {
                Console.WriteLine(res[i, 0]);
                Console.WriteLine(res[i, 1]);
            }
        }
    }
}
