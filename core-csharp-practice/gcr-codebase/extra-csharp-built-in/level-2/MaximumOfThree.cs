using System;

class Random
{
    // Method to find maximum
    static int Max(int a, int b, int c)
    {
        int m = a;

        if (b > m)
        {
            m = b;
        }
        if (c > m)
        {
            m = c;
        }

        return m;
    }

    static void Main(string[] args)
    {
        // Taking the input from the user
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());

        // Displaying the result
        int res = Max(x, y, z);
        Console.WriteLine(res);
    }
}
