using System;

class Random
{
    public static bool CanStudentVote(int age)
    {
        if (age < 0)
            return false;

        return age >= 18;
    }

    static void Main()
    {
        int[] ages = new int[10];

        // User Input  loop
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write("Enter age of student "+(i + 1));
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CanStudentVote(ages[i]) ? "Can Vote" : "Cannot Vote");
        }
    }
}
