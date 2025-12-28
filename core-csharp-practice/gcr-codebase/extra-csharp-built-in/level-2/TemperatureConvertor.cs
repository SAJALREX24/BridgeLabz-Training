using System;

class Random{

    // Fahrenheit to Celsius
    static double ToCelsius(double fahrenheit){
        return (fahrenheit-32)*5/9;
    }

    // Celsius to Fahrenheit
    static double ToFahrenheit(double celsius){
        return (celsius*9/5)+32;
    }

    static void Main(string[] args){

		// Taking the input from the user
		
        double value=double.Parse(Console.ReadLine());
        int choice=int.Parse(Console.ReadLine());

	
		
        if(choice==1){
            Console.WriteLine(ToCelsius(value));
        }
        else{
            Console.WriteLine(ToFahrenheit(value));
        }
    }
}
