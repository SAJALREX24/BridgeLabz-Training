using System;

class ATMDispenser
{
    static void Main(string[] args)
    {
        // Scenario 1: Includes ₹500 notes
        int[] denomination = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };

        // Scenario 2: Excludes ₹500 notes
        int[] denomination2 = { 200, 100, 50, 20, 10, 5, 2, 1 };

        Console.WriteLine("Select dispensing scenario (A / B / C):");
        Console.WriteLine("A - Best combination using ₹500");
        Console.WriteLine("B - Best combination without ₹500");
        Console.WriteLine("C - Default fallback combination");

        string choice = Console.ReadLine().ToUpper();

        Console.Write("Enter withdrawal amount: ");
        int amount = int.Parse(Console.ReadLine());

        int dispensed = 0;
        int totalNotes = 0;

        int[] selectedDenomination;

        switch (choice)
        {
            case "A":
                selectedDenomination = denomination;
                break;

            case "B":
                selectedDenomination = denomination2;
                break;

            case "C":
                selectedDenomination = denomination; // attempt all denominations
                break;

            default:
                Console.WriteLine("Invalid option selected.");
                return;
        }

        Console.WriteLine("\nProcessing cash dispense...");

        // Iterate through selected denominations
        for (int i = 0; i < selectedDenomination.Length; i++)
        {
            while (selectedDenomination[i] <= (amount - dispensed))
            {
                dispensed += selectedDenomination[i];
                totalNotes++;
                Console.WriteLine("Note issued: ₹" + selectedDenomination[i]);
            }

            if (dispensed == amount)
                break;
        }

        if (dispensed < amount)
        {
            Console.WriteLine("\nExact amount cannot be dispensed.");
            Console.WriteLine("Amount dispensed so far: ₹" + dispensed);
        }
        else
        {
            Console.WriteLine("Dispense successful!");
            Console.WriteLine("Total amount dispensed: ₹" + dispensed);
            Console.WriteLine("Total notes used: " + totalNotes);
        }
    }
}
