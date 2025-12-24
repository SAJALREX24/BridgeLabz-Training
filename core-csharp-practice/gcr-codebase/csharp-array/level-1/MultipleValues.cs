using System;

class Random{
	static void Main(String[] args){
		
		// Creating array of given size
		double[] numbers=new double[10];
		
		// Creating variable 
		double total=0.0;
		
		// Creating variable index
		int index=0;
		
		while(true){
		
		double input=double.Parse(Console.ReadLine());
		
		if(input<=0){
			break;
		}
		if(index==10){
			break;
		}
		
		numbers[index]=input;
		
		index++;
		}
		
		// Displaying the results
		for(int i=0;i<index;i+){
			Console.WriteLine(numbers[i]);
			total+=numbers[i];
		}
		
		// Total Sum
		Console.WriteLine("Sum of all numbers : "+total);
	}
}