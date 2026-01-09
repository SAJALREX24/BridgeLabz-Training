using System;

class Random{
	static void Main(String[] args){
		
		//Creating the variables 
		int height=int.Parse(Console.ReadLine());
		int bases=int.Parse(Console.ReadLine());
	
		
		//Calculating the area of the triangle
		double areaOfTriangle=(1.0/2.0)*bases*height;
		
		//Creating variables for inches and feets
		double inch=areaOfTriangle/(2.54*2.54);
		double feet=inch/(12*12);
		
		
		
		//Displaying the result
		Console.WriteLine("Area of Triangle in cm "+areaOfTriangle+" while in feet "+feet+" and inches is "+inch);
	}
}