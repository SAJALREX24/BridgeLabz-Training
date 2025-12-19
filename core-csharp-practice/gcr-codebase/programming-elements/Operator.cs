using System;
class Random{
	
	static void Main(String [] args){
		int FIRST=24;
		int SECOND=24;
		
		Console.WriteLine("Addition (+)");
		Console.WriteLine(FIRST+SECOND);
		Console.WriteLine("Subtraction (-)");
		Console.WriteLine(FIRST-SECOND);
		Console.WriteLine("Multiplication (*)");
		Console.WriteLine(FIRST*SECOND);
		Console.WriteLine("Division (/)");
		Console.WriteLine(FIRST/SECOND);
		Console.WriteLine("Modulus (%)");
		Console.WriteLine(FIRST%SECOND);
		
		Console.WriteLine("RELATIONAL OPERATORS");
		
		
		Console.WriteLine("Equal to (==)");
		Console.WriteLine(FIRST==SECOND);
		Console.WriteLine("Not equal to (!=)");
		Console.WriteLine(FIRST!=SECOND);
		Console.WriteLine("Greater than (>)");
		Console.WriteLine(FIRST>SECOND);
		Console.WriteLine("Less than (<)");
		Console.WriteLine(FIRST<SECOND);
		Console.WriteLine("Greater than or equal to (>=)");
		Console.WriteLine(FIRST>=SECOND);
		Console.WriteLine("Less than or equal to (<=)");
		Console.WriteLine(FIRST<=SECOND);
		
		
		Console.WriteLine("Logical Operators");
		bool BEN=false;
		bool TENNYSON=true;
		Console.WriteLine("Logical AND (&&)");
		Console.WriteLine(BEN&&TENNYSON);
		Console.WriteLine("Logical OR (||)");
		Console.WriteLine(BEN||TENNYSON);
		Console.WriteLine("Logical NOT (!)");
		Console.WriteLine(!BEN);
		
		
		Console.WriteLine("Assignment Operators");
		
		
		Console.WriteLine("Assignment (=)");
		Console.WriteLine(FIRST=SECOND);
		Console.WriteLine("Addition assignment (+=)");
		Console.WriteLine(FIRST+=SECOND);
		Console.WriteLine("Subtraction assignment (-=)");
		Console.WriteLine(FIRST-=SECOND);
		Console.WriteLine("Multiplication assignment (*=)");
		Console.WriteLine(FIRST*=SECOND);
		Console.WriteLine("Division assignment (/=)");
		Console.WriteLine(FIRST/=SECOND);
		Console.WriteLine("Modulus assignment (%=)");
		Console.WriteLine(FIRST%=SECOND);
		
		
		
		Console.WriteLine("Unary Operators");
		
		
		
		Console.WriteLine("Increment (++)");
		Console.WriteLine(FIRST++);
		Console.WriteLine("Decrement(--)");
		Console.WriteLine(FIRST--);
		Console.WriteLine("Logical complement(!)");
		Console.WriteLine(!BEN);
		
		
		
		Console.WriteLine("Ternary Operator");
		int max=(FIRST>SECOND)?FIRST:SECOND;
		
		Console.WriteLine("MAX :"+max);
		
		
		Console.WriteLine("is Operator");
		Console.WriteLine(FIRST is Random);
		
		
		
		
		
		
		
		
		
		
	}
}