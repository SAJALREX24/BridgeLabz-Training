using System;

class Random
{
	static void Main(String[] args){
		
		// Taking value from the user
		int number=int.Parse(Console.ReadLine());
		
		// Creating a variable 
		int sum=0;
		
		// Finding the divisors 
		for(int iterator=1;iterator<number;iterator++){
			if(number%iterator==0){
				sum+=iterator;
			}
		}
		
		// Displaying the result 
		if(sum>number){
			Console.WriteLine("Abundant Number");
		}
		else{
			Console.WriteLine("Abundant Number");
		}
		
	}
}