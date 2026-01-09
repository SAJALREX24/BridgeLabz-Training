using System;

class Random{
	static void Main(String[] args){
		
		// Implementing array with the given size
		int[] arrayOfNumbers=new int[5];   
		
		
		for(int i=0;i<arrayOfNumbers.Length;i++){
			arrayOfNumbers[i]=int.Parse(Console.ReadLine());
			if(arrayOfNumbers[i]>0){
				if(arrayOfNumbers[i]%2==0){
					Console.WriteLine("Even");
				}
				else{
					Console.WriteLine("odd");
				}
			}
			else if(arrayOfNumbers[i]==0){
				Console.WriteLine("zero");
			}
			
		}

			
			if(arrayOfNumbers[0]==arrayOfNumbers[arrayOfNumbers.Length-1]){
				Console.WriteLine("Equal");
			}
			else if(arrayOfNumbers[0]>arrayOfNumbers[arrayOfNumbers.Length-1]){
				Console.WriteLine("Greater");
			}
			else{
				Console.WriteLine("Less");
			}
	}
}
