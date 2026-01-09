using System;

class Random{
	static void Main(String[] args){
		
		//Creating variables
		int costPrice=129;
		int sellingPrice=191;
		
		//Creating variables 
		float profit=sellingPrice-costPrice;
		float profitPercent=(profit/costPrice)*100f;
		
		//Displaying the Result
		Console.WriteLine("The Cost Price is INR"+ costPrice +"and Selling Price is INR"+ sellingPrice +"\nThe Profit is INR"+ profit +"and the Profit Percentage is"+ profitPercent);
		
	}
}