using System;

class Random{
	static void Main(String[] args){
		
		// Taking input from the user
        int number=int.Parse(Console.ReadLine());

        
        int[,] marks=new int[number,3];

        //Creating the arrays to store percentage and grade
        double[] percentage=new double[number];
        string[] grade=new string[number];

        // Taking the marks as input from the user
        for(int i=0;i<number;i++){

            for(int j=0;j<3;j++){
				
                if(j==0)
                    Console.Write("Enter Physics marks");
                else if(j==1)
                    Console.Write("Enter Chemistry marks");
                else
                    Console.Write("Enter Maths marks");

                marks[i,j]=int.Parse(Console.ReadLine());

                // Checking if marks are negative, ask again
                if(marks[i,j]<0)
                {
                    Console.WriteLine("Marks must be positive.Enter again.");
                    j--;
                }
            }
        }

        // Calculating percentage and grade
        for(int i=0;i<number;i++)
        {
            int total=marks[i,0]+marks[i,1]+marks[i,2];
            percentage[i]=(total*100)/300.0;

            if(percentage[i]>=80)
                grade[i]="A";
            else if(percentage[i]>=70)
                grade[i]="B";
            else if(percentage[i]>=60)
                grade[i]="C";
            else if(percentage[i]>=50)
                grade[i]="D";
            else if(percentage[i]>=40)
                grade[i]="E";
            else
                grade[i]="R";
        }

        // Displaying the final result
     
        for(int i=0;i<number;i++){
			
            Console.WriteLine(marks[i,0]+" "+marks[i,1]+" "+marks[i,2]+" "+percentage[i]+" "+grade[i]);
        }
		
	}
}