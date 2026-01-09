using System;

class Random
{
    static void Main(string[] args)
    {
        // Declaring variable
        int age;

        // Taking input
        Console.WriteLine("Enter age");
        age = int.Parse(Console.ReadLine());

        
        if (age >= 18)
        {
            Console.WriteLine("The person's age is "+age+" and can vote.");
        }
        else
        {
            Console.WriteLine("The person's age is "+age+" and cannot vote");
        }
    }
}


	
	
