using System;

class Random{
	 static void Main(){
		
		// Taking user input 
		int rows=int.Parse(Console.ReadLine());
		int columns=int.Parse(Console.ReadLine());
		
		
		int[,] matrix=new int[rows,columns];
		
		// Taking input for 2-d array element using nested for loop
		for(int i=0;i<rows;i++){
			for(int j=0;j<columns;j++){
				matrix[i,j]=int.Parse(Console.ReadLine());
			}
		}
		
		// Creating a 1-d array
		int[] array=new int[rows*columns];
		
		// Creating a variable for index;
		int index=0;
		
		// Transfering the elements from 2-d array to 1-d array
		for(int i=0;i<rows;i++){
			for(int j=0;j<columns;j++){
				array[index]=matrix[i,j];
				index++;
			}
		}
		
		// Displaying the results
		for(int i=0;i<array.Length;i++){
			Console.Write(array[i]+" ");
		}
		
	}
}