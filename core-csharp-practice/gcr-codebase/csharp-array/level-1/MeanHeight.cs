using System;

class Random{
	static void Main(String[] args){
		
		// Creating a array 
		double[] height=new double[11];
		
		// Creating a variable 
		double sum=0;
		
		// Creating a variable 
		double meanHeight=0.0;
		
		// Taking the input from the user for heights
		for(int i=0;i<height.Length;i++){
			
			height[i]=double.Parse(Console.ReadLine());
			
			// Taking the sum also
			sum+=height[i];
			
		}
		
		meanHeight=sum/11;
		
		// Displaying the results
		Console.WriteLine(meanHeight);
		
	}
}