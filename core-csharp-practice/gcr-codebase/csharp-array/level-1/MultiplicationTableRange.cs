using System;

class MultiplicationTableRange{
	static void Main(String[] args){
		
		// Creating the variable 
		int number=int.Parse(Console.ReadLine());
		
		// Implementing array with the given size
		int[] arrayOfNumber=new int[4];
		
		
		for(int i=6;i<=9;i++){
			
			arrayOfNumber[i-6]=number*i;
			
		}
			
		// Displaying the result
		for(int i=6;i<=9;i++){
			
			Console.WriteLine(number+" * "+i+" = "+arrayOfNumber[i-6]);
			
		}
	}
}