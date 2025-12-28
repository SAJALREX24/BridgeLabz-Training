using System;

class Random
{
    // Method to generate fibonacci
    static void Fib(int n)
    {
        int a = 0;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a);
            int c = a + b;
            a = b;
            b = c;
        }
    }

    static void Main(string[] args)
    {
        // Taking the input from the user
        int n = int.Parse(Console.ReadLine());

        // Displaying the result
        Fib(n);
    }
}
