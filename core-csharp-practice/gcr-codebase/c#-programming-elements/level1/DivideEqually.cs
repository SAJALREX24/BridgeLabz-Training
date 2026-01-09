using System;

class Random{
	static void Main(String[] args){
		
		//Creating variables 
		int pens=14;
		int students=3;
		
		//Creating variables 
		int penPerStudent=pens/students;
		int remainingPens=students%pens;
		
		//Displaying the results
		Console.WriteLine("The Pen Per Student is "+ penPerStudent +" and the remaining pen not distributed is "+remainingPens);
	}
}