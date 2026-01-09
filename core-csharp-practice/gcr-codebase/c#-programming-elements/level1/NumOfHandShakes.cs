using System;

class Random{
	static void Main(String[] args){
	
	//Creating variable to store Number of Students
	int noOfStudents=int.Parse(Console.ReadLine());
	
	//Performing the calculation for number of handshakes
	int noOfHandShakes=(noOfStudents*(noOfStudents-1))/2;
	
	//Displaying the result
	Console.WriteLine(noOfHandShakes);
	
    }
}