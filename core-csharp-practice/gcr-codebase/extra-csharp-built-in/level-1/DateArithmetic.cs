using System;

class Random{

    static void Main(string[] args){

        // Take date input
        DateTime date=DateTime.Parse(Console.ReadLine());

       
        date=date.AddDays(7);
        date=date.AddMonths(1);
        date=date.AddYears(2);

        // Subtract 3 weeks
        date=date.AddDays(-21);

        // Display result
        Console.WriteLine(date);
    }
}
