using System;

class Random
{
    static void Main(string[] args)
    {
        // User Input 
        Console.WriteLine("Enter a positive number");
        int number = int.Parse(Console.ReadLine());

        int counter = 1;

       
        while (counter <= number)
        {
            if (counter % 3 == 0 && counter % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (counter % 3 == 0)
                Console.WriteLine("Fizz");
            else if (counter % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(counter);

            counter++;
        }
    }
}
