using System;

class Random{
	static void Main(String[] args){
		
		//Creating variables 
		double pi=3.14f;
		double radiusKm=6378f;
		
		//Creating variable 
		double radiusMiles=radiusKm*0.621371f;
		
		//Creating variables
		double volumeKm=(4.0/3.0)*pi*(radiusKm*radiusKm*radiusKm);
		double volumeM=(4.0/3.0)*pi*(radiusMiles*radiusMiles*radiusMiles);
		
		//Displaying the result
		Console.WriteLine("The Volume of earth in cubic kilometers is "+volumeKm+" and cubic miles is "+volumeM);
		
	}
}