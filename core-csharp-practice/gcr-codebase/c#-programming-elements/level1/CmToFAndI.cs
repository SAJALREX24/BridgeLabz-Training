using System;

class Random{
	static void Main(String[] args){
		
		//Creating variable for height 
		float height=float.Parse(Console.ReadLine());
		
		//Creating variable for inches and feets
		double inch=height/(2.54*2.54);
		double feet=inch/(12*12);
		
		//Displaying the results
		Console.WriteLine("Your Height in cm is "+height+" while in feet is "+feet+" and inches id "+inch);
	}
}