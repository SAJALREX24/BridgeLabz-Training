using System;

class Random{
	static void Main(String[] args){
		
		// Taking the value of number from the user
		int number=int.Parse(Console.ReadLine());
		
		
		if(number>=1){
			
			
			int[] numbersEven=new int[number/2+1];
			int[] numbersOdd=new int[number/2+1];
			int evenIndex=0;
			int oddIndex=0;
			
			
			for(int i=1;i<number;i++){
				if(i%2==0){
					numbersEven[evenIndex]=i;
					evenIndex++;
				}
				else{
					numbersOdd[oddIndex]=i;
					oddIndex++;
				}
			}
			
			// displaying the odd and even arrays
			for(int i=0;i<=evenIndex;i++){
				Console.WriteLine("This is even : "+numbersEven[i]);
			}
			
			for(int i=0;i<=oddIndex;i++){
				Console.WriteLine("This is odd : "+numbersOdd[i]);
			}
			
			
		}
		else{
			Console.WriteLine("Error is Thrown");
		}
		
			
		
	}
}