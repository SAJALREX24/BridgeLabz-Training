using System;

class Random{
	static void Main(String[] args){
		
		
		
        int number=int.Parse(Console.ReadLine());

      
        double[] height=new double[number];
        double[] weight=new double[number];
        double[] bmi=new double[number];
        string[] status=new string[number];

        // Taking the input from the user
		
        for(int iterator=0;iterator<number;iterator++){
 
            height[iterator]=double.Parse(Console.ReadLine());

            weight[iterator]=double.Parse(Console.ReadLine());
        }

        // Calculating BMI and finding the status
        for(int iterator=0;iterator<number;iterator++){
			
            bmi[iterator]=weight[iterator]/(height[iterator]*height[iterator]);

            if(bmi[iterator]<=18.4)
                status[iterator]="Underweight";
            else if(bmi[iterator]>=18.5&&bmi[iterator]<=24.9)
                status[iterator]="Normal";
            else if(bmi[iterator]>=25.0&&bmi[iterator]<=39.9)
                status[iterator]="Overweight";
            else
                status[iterator]="Obese";
        }

        // Displaying the result 
        for(int iterator=0;iterator<number;iterator++)
        {
            Console.WriteLine(height[iterator]+weight[iterator]+bmi[iterator]+status[iterator]);
        }
    }
 }
		
 