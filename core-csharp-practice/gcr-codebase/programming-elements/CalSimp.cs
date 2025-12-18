using System;
class Random{
	
	static void Main(String [] args){
		int principal=24;
		double rate=2.4;
		int time=24;
		double simpleinterest=(principal*rate*time)/100;
		Console.WriteLine(simpleinterest);
	}
}