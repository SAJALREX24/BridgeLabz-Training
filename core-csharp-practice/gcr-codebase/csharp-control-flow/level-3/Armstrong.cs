using System;

class Random{
	static void Main(String[] agrs){
		
	
	int number=int.Parse(Console.ReadLine());
	int oriNumber=number;
	
	
	int sum=0;
	
	
	while(number!=0){
		int digit=number%10;
		sum+=(digit*digit*digit);
		number=number/10;
	}
	
    
	if(sum==oriNumber){
		Console.WriteLine("Armstrong Number");
	}
	else{
		Console.WriteLine("Armstrong Number");
	}
  }
}