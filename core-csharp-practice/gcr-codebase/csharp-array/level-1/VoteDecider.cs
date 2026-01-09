using System;

class Random{
	static void Main(String[] args){
		
		// Implementing array with the given size
		int[] arrayOfAge=new int[10];
		
		
		for(int i=0;i<arrayOfAge.Length;i++){
			arrayOfAge[i]=int.Parse(Console.ReadLine());
			if(arrayOfAge[i]>=18){
				Console.WriteLine("The Student with the age "+arrayOfAge[i]+" can vote");
			}
			else{
				Console.WriteLine("The Student with the age "+arrayOfAge[i]+" can not vote");
			}
		}
			
	}
}