using System;

class Random
{
    public static double CalculateBmi(double weight, double heightCm)
    {
        double heightMeter = heightCm / 100;
        return weight / (heightMeter * heightMeter);
    }

    static void Main()
    {
        double[,] data = new double[10, 3];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter weight (kg) ");
            data[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height (cm) ");
            data[i, 1] = Convert.ToDouble(Console.ReadLine());

            data[i, 2] = CalculateBmi(data[i, 0], data[i, 1]);

            Console.WriteLine("BMI: " + data[i, 2]);
        }
    }
}
