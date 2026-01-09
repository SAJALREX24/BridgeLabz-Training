using System;

class Random{
	
	static void Main(String[] args){
		
		// Taking the input from the user
        int number=int.Parse(Console.ReadLine());

		// Creating variable 
        int temp=number;
        int count=0;

        // Finding the number of digits
        while(temp>0){
			
            count++;
            temp=temp/10;
        }

        // Creating an array to store digits
        int[] digits=new int[count];

        temp=number;

        // Storing the digits in an array
        for(int i=0;i<count;i++){
			
            digits[i]=temp%10;
            temp=temp/10;
        }

        
        int[] frequency=new int[10];

      
        for(int iterator=0;iterator<count;iterator++){
			
            frequency[digits[iterator]]++;
        }

        // Displaying the results frequency of each digit
        for(int iterator=0;iterator<10;iterator++){
			
            if(frequency[iterator]>0){
				
                Console.WriteLine("Digit "+iterator+" occurs "+frequency[iterator]+" times");
            }
        }
		
	}
}