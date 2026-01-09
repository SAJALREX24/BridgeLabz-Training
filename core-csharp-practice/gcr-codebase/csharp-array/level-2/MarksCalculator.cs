using System;

class Random{
	static void Main(String[] args){
		
		// Taking from the user
    
        int number=int.Parse(Console.ReadLine());

        
        int[] physics=new int[number];
        int[] chemistry=new int[number];
        int[] maths=new int[number];
        double[] percentage=new double[number];
        char[] grade=new char[number];

        // Taking the input of marks from the user
        for(int i=0;i<number;i++){
			
            physics[i]=int.Parse(Console.ReadLine());

            chemistry[i]=int.Parse(Console.ReadLine());

            maths[i]=int.Parse(Console.ReadLine());

            // If the marks are negative
            if(physics[i]<0||chemistry[i]<0||maths[i]<0){	
                i--;
            }
        }

        // Calculating the percentage and grade
        for(int i=0;i<number;i++){
			
            percentage[i]=(physics[i]+chemistry[i]+maths[i])*100/300;

            if(percentage[i]>=80)
                grade[i]='A';
            else if(percentage[i]>=70)
                grade[i]='B';
            else if(percentage[i]>=60)
                grade[i]='C';
            else if(percentage[i]>=50)
                grade[i]='D';
            else if(percentage[i]>=40)
                grade[i]='E';
            else
                grade[i]='R';
        }

        // Displaying the result
        for(int iterator=0;iterator<number;iterator++){
			
            Console.WriteLine(physics[iterator]+" "+chemistry[iterator]+" "+maths[iterator]+" "+percentage[iterator]+" "+grade[iterator]);
        }
		
	}
}