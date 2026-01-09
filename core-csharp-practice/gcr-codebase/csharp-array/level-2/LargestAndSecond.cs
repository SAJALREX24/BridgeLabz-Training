using System;

class Random{
	static void Main(){
		//Taking input from user
        int number=int.Parse(Console.ReadLine());

        // Creating variable 
        int maxDigit=10;
        int[] digits=new int[maxDigit];

        //Creating a index variable
        int index=0;

        //Using while loop until number becomes 0
        while(number!=0){
			
            // Checking if index is equal to maxDigit
            if(index==maxDigit){
				
				maxDigit=maxDigit+10;
                int[] temp=new int[maxDigit];

               //Copying the existing digits into temporary array
                for(int i=0;i<index;i++){
					
                    temp[i]=digits[i];
                }

                digits=temp;
            }

            
            digits[index]=number%10;
            number=number/10;

            index++;
        }

        //Creating variables for largest and second largest
        int largest=0;
        int secondLargest=0;

        //Finding the largest and second largest digit
        for (int i=0;i<index;i++){
			
            if (digits[i]>largest){
				
                secondLargest=largest;
                largest=digits[i];
            }
            else if (digits[i]>secondLargest&&digits[i]!=largest){
                secondLargest=digits[i];
            }
        }

        //Displaying the results
        Console.WriteLine(largest);
        Console.WriteLine(secondLargest);
	}
}