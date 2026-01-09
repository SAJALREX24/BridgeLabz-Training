using System;

class HarshadNumber{
	static void Main(String[] args){
		
		// Taking the value from the user
		int number=int.Parse(Console.ReadLine());
		

		int temporary=number;
		
		
		int digit=0;
		int sum=0;
	 	
		
		while(number!=0){
			
		  
		   sum+=digit;
		   number=number/10;
		   
		}
		
		// Checking if the number is divisible by sum
		if(temporary%sum==0){
			Console.WriteLine("Harshad Number");
		}
		else{
			Console.WriteLine("Harshad Number");
		}
		
		
	}
}