using System;

class Random
{
    
    public static int GenerateOtp()
    {
        System.Random randomObject = new System.Random();

        // Generate random 6-digit OTP
        return randomObject.Next(100000, 1000000);
    }

    static void Main()
    {
        // Generate OTP
        int otpValue = GenerateOtp();

        // Displaying OTP
        Console.WriteLine("Generated OTP: " + otpValue);
    }
}
