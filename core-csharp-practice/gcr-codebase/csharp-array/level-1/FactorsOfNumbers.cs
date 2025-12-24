using System;

class Random{
	static void Main(String[] args){
		
		// Taking the input from the user
		int number=int.Parse(Console.ReadLine());
		
		// Creating a variables
		int maxFactor=10;
		int index=0;
		
		// Creating a array for storing the factors
		int[] factors=new int[maxFactor];
		
		// Find factors from 1 to the number using for loop
		for(int i=1;i<=number;i++){
			if(number%i==0){
				
				// if index is same as the maxFactor
				if(index==maxFactor){
					maxFactor=maxFactor*2;
					int[] temporary=new int[maxFactor]; 
					
					// copying element
					for(int j=0;j<index;j++){
						temporary[j]=factors[j];
					}
					
					factors=temporary;
				}
				
				factors[index]=i;
				index++;
			}
		
	    }
		// Displaying the results
		for(int k=0;k<index;k++){
			Console.WriteLine(factors[k]);
		}
    }
}