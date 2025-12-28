using System;

class Random
{
    // Method to show exception
    static void ShowEx()
    {
        try
        {
            string s = "Hello";
            Console.WriteLine(s[10]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("IndexOutOfRangeException");
        }
    }

    static void Main(string[] args)
    {
        ShowEx();
    }
}
