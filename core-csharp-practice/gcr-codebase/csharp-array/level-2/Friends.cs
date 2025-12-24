using System;

class Random{
	static void Main(String[] args){
		
		
		//Creating an array 
		string[] names={"Sam","Ben","bunny"};
		
		// Creating two arrays 
		int[] age=new int[3];
        double[] height=new double[3];

        // Taking input from the user of the two arrays one by one
        for (int i=0;i<3;i++){
			
            Console.WriteLine(names[i]);

            age[i] = int.Parse(Console.ReadLine());

            height[i] = double.Parse(Console.ReadLine());
        }

        // Creating variables youngest and tallest
        int youngestIndex = 0;
        int tallestIndex = 0;

        // Finding the youngest and tallest
        for (int i=1;i<3;i++){
			
            if (age[i]<age[youngestIndex]){
				
                youngestIndex = i;
            }

            if (height[i] > height[tallestIndex]){
				
                tallestIndex = i;
            }
        }

        // Displaying the results
        Console.WriteLine(names[youngestIndex]);
        Console.WriteLine(names[tallestIndex]);
		
	}
}