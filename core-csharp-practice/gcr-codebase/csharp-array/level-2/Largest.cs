using System;

class Random{

	static void Main(String[] args){
		
		// Taking input from user
        int number = int.Parse(Console.ReadLine());

        // Creating variable
        int maxDigit = 10;
        int[] digits = new int[maxDigit];

        // Creating a variable
        int indi = 0;

        while(number!=0){
			
            if(indi==maxDigit){
				
                break;
            }

            
			
            digits[indi]=number%10;
            number=number/10;

            indi++;
        }

        //Creating variables for largest and second largest
        int largest = 0;
        int secondLargest = 0;

        //Finding the largest and second largest
        for(int i=0;i<indi;i++){
            if (digits[i]>largest){
				
                secondLargest=largest;
                largest=digits[i];
            }
            else if(digits[i]>secondLargest&&digits[i]!=largest){
                secondLargest = digits[i];
            }
        }

        //Displaying the results
        Console.WriteLine(largest);
        Console.WriteLine(secondLargest);
		
	}

}