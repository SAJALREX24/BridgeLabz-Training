using System;

class Random
{
    static void Main()
    {
        // User Input:
        Console.Write("Enter number of students");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        // Result:
        Console.WriteLine("Total possible handshakes "+ handshakes);
    }
}
