using System;

class Random{
	 private int age=24;
	 public string name="SAJAL-SARASWAT";
	 protected string position="The Throne";
	 internal string gun="M16";
	 protected internal string cartoon="BEN 10";
		
     //	private protected int money=24000;  //
	
	    static void Main(String[] args){
		
		Random first=new Random();
		
		
		Console.WriteLine(first.name);
		Console.WriteLine(first.age);
		Console.WriteLine(first.position);
		Console.WriteLine(first.gun);
		Console.WriteLine(first.cartoon);
	//	Console.WriteLine(first.money); 
		
		
	    }
	
}