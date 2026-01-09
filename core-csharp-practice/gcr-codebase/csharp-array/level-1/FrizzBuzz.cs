using System;

class Random{
	static void Main(String[] args){
		
		// Taking the input from the user
		int number=int.Parse(Console.ReadLine());
		
		// Creating a string array
		string[] results=new string[number+1];
		
		
		for(int i=0;i<=number;i++){
			if(i==0){
				results[i]="0";
			}
			else if(i%3==0 && i%5==0){
				results[i]="FrizzBuzz";
			}
			else if(i%3==0){
				results[i]="Frizz";
			}
			else if(i%5==0){
				results[i]="Buzz";
			}
			else{
				results[i]=i.ToString();
			}
		}
		
		// Displaying the results
		for(int i=0;i<=number;i++){
			Console.WriteLine(results[i]);
		}
	}
}