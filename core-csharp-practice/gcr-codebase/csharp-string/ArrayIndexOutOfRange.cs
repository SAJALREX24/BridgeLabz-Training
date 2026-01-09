using System;

class Random
{
    // Method to show exception
    static void ShowEx()
    {
        try
        {
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(arr[5]);
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
