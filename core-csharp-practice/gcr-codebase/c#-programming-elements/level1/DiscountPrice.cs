using System;

class Random{
	static void Main(String[] args){
		
		//Creating variables for storing fee, discount percent
		int fee=125000;
		float discountPercent=10f;
		
		// alculating discount
		float discount=(discountPercent/100)*fee;
		
		//Displaying result
		Console.WriteLine("The discount amount is INR "+discount+" and the final discounted fee is INR "+(fee-discount));
		
		
	}
}