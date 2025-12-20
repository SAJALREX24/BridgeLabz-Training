using System;

class Random {
	
    static void Main(String[] args) {
		 //Reading first number from user
		Console.Write("Enter first number");
        int number1 = Convert.ToInt32(Console.ReadLine());
		
        //Reading second number from user
        Console.Write("Enter second number");
        int number2 = Convert.ToInt32(Console.ReadLine());
		
        //Calculate quotient using division operator
        int quotient = number1 / number2;
		
		//Calculate remainder using modulus operator
		int remainder = number1 % number2;
		
        //Displaying result
        Console.WriteLine("The Quotient is "+quotient+" and Remainder is "+remainder+" of two numbers "+number1+" and "+number2);
		
		

		
		
		
		
		
}
}
