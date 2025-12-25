using System;

class Random
{
    // Method for calculating maximum handshakes
    public static int CalculateHandshakes(int numberOfStudents)
    {
        
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
        return handshakes;
    }

    static void Main()
    {
        // User input
        Console.Write("Enter number of students");
        int students = Convert.ToInt32(Console.ReadLine());

        // Method call
        int result = CalculateHandshakes(students);
        Console.WriteLine("Maximum Handshakes" + result);
    }
}
