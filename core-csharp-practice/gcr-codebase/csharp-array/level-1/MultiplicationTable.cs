using System;

class Random{
	static void Main(String[] args){
		
		// Creating the variable
		int number=int.Parse(Console.ReadLine());
		
		// Implementing array 
		int[] arrayOfNum=new int[10];
		
		
		for(int i=1;i<arrayOfNum.Length;i++){
			
			arrayOfNum[i]=number*i;
			
		}
			
		// Displaying the result
		for(int i=0;i<arrayOfNum.Length;i++){
			
			Console.WriteLine(arrayOfNum[i]);
			
		}
	}	
			
}
