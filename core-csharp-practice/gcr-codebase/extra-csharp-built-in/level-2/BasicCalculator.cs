using System;

class Random
{
    // Addition Method
    static double Add(double a, double b)
    {
        return a + b;
    }

    // Subtraction Method
    static double Sub(double a, double b)
    {
        return a - b;
    }

    // Multiplication Method
    static double Mul(double a, double b)
    {
        return a * b;
    }

    // Division Method
    static double Div(double a, double b)
    {
        return a / b;
    }

    static void Main(string[] args)
    {
        // Taking the input from the user
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        int ch = int.Parse(Console.ReadLine());

        // Displaying the result according to the choice from the user
        if (ch == 1)
        {
            Console.WriteLine(Add(x, y));
        }
        else if (ch == 2)
        {
            Console.WriteLine(Sub(x, y));
        }
        else if (ch == 3)
        {
            Console.WriteLine(Mul(x, y));
        }
        else
        {
            Console.WriteLine(Div(x, y));
        }
    }
}
