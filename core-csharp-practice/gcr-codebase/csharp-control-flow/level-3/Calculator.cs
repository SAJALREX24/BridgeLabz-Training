using System;

class Random{
	static void Main(String[] args){
		
		
		double first=double.Parse(Console.ReadLine());
		double second=double.Parse(Console.ReadLine());
		
		string op=Console.ReadLine();
		
		
		switch(op){
			case "+":
			Console.WriteLine("Output is : "+(first+second));
			break;
			
			case "-":
			Console.WriteLine("Output is : "+(first-second));
			break;
			
			case "*":
			Console.WriteLine("Output is : "+(first*second));
			break;
			
			case "/":
			Console.WriteLine("Output is : "+(first/second));
			break;
			
			default :
			Console.WriteLine("Invalid operator");
			break;
		}
		
		
	}
}