using System;

class Random{
	
	static void Main(String[] args){
		
		// Taking the total number of employees
        int totalEmployees = 10;

        // Creating arrays 
        double[] salary = new double[totalEmployees];
        double[] yearsOfService = new double[totalEmployees];

        //Creating arrays 
        double[] bonus = new double[totalEmployees];
        double[] newSal = new double[totalEmployees];

        //Creating variables 
        double totalBonus = 0;
        double totalOldSalary = 0;
        double totalNewSalary = 0;

        // Taking the inputs from the user of different arrays
        for (int iterator=0;iterator<totalEmployees;iterator++){
        
            salary[iterator] = double.Parse(Console.ReadLine());

            yearsOfService[iterator] = double.Parse(Console.ReadLine());

            if (salary[iterator]<=0||yearsOfService[iterator]<0){
                iterator--;   // decrement index 
                continue;
            }

            totalOldSalary+=salary[iterator];
        }

        // Calculating bonus and new salary and checking the conditions also
        for (int iterator=0;iterator<totalEmployees;iterator++){
        
            
            if (yearsOfService[iterator]>5){
                bonus[iterator]=salary[iterator]*0.05; 
            }
            else{
                bonus[iterator]=salary[iterator]*0.02;
            }

            newSal[iterator]=salary[iterator]+bonus[iterator];

            totalBonus+=bonus[iterator];
            totalNewSalary+=newSal[iterator];
        }

        // Displaying the results 
        Console.WriteLine(totalOldSalary);
        Console.WriteLine(totalBonus);
        Console.WriteLine(totalNewSalary);
    }
}

		