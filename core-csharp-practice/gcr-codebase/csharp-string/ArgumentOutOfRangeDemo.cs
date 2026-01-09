using System;

class Random
{
    // Method to show exception
    static void ShowEx()
    {
        try
        {
            string s = "Hello";
            Console.WriteLine(s.Substring(4, 10));
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("ArgumentOutOfRangeException");
        }
    }

    static void Main(string[] args)
    {
        ShowEx();
    }
}
