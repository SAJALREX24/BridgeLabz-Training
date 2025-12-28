using System;

class Random
{
    // Method to show exception
    static void ShowEx()
    {
        try
        {
            string s = "abc";
            int n = int.Parse(s);
            Console.WriteLine(n);
        }
        catch (FormatException)
        {
            Console.WriteLine("FormatException");
        }
    }

    static void Main(string[] args)
    {
        ShowEx();
    }
}
