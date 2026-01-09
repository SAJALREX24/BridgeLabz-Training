using System;

class Random{
	static void Main(String[] args){
		
		//Taking the input from the user
        int number=int.Parse(Console.ReadLine());
		
		
        int temporaryNumber=number;

        //Finding the count of the digits
        int counter=0;
        while(temporaryNumber!=0){
			
            counter++;
            temporaryNumber=temporaryNumber/10;
        }

        // Creating a array to store digits
        int[] digits=new int[counter];
        int index=0;

        // Storing the digits in an array
        while(number!=0){
			
            digits[index]=number%10;
            number=number/10;
            index++;
        }

        //Storing the array elements in reverse order
        int[] reverseArray=new int[counter];

        // Copying the digits into reverse array
        for(int i=0;i<counter;i++){
			
            reverseArray[i]=digits[counter-1-i];
        }

        //Displaying the result
        for(int i=0;i<counter;++){
			
            Console.Write(reverseArray[i]);
        }
	}
}