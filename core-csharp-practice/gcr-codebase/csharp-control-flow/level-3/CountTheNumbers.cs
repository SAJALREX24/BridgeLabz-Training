using System;

class CountTheNumbers{
	static void Main(String[] args){
		
		// Taking the value from the user
		int number=int.Parse(Console.ReadLine());
		int count=0;
		
		
		while(number!=0){
			
			
		    number=number/10;
		    count++;
			
		}
		
		Console.WriteLine("The Number of Digits are"+count);
		
	}
}