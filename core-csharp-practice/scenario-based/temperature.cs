/* Arrays – Temperature Analyzer 1. Scenario: You're analyzing a week’s worth of hourly temperature data stored in a 2D array (float[7][24]). 
Problem: Write a method to:
 ● Find the hottest and coldest day, 
 ● Return average temperature per day. 
2. Scenario: Develop a program to manage student test scores. 
The program should: 
● Store the scores of n students in an array.
 ● Calculate and display the average score. 
 ● Find and display the highest and lowest scores. 
 ● Identify and display the scores above the average. 
 ● Handle invalid input like negative scores or non-numeric input. */















using System;

class ArraysScenarioBased
{
    
    static void TemperatureAnalyzer()
    {
        // Stores temperatures for 7 days and 24 hours each
        float[,] temperatures = new float[7, 24];

        Console.WriteLine("Enter temperature for 7 days (24 hours each):");

        // Input temperatures
        for (int day = 0; day < 7; day++)
        {
            Console.WriteLine("Day " + (day + 1));
            for (int hour = 0; hour < 24; hour++)
            {
                temperatures[day, hour] = float.Parse(Console.ReadLine());
            }
        }

        // Initialize hottest and coldest values
        float hottestTemp = temperatures[0, 0];
        float coldestTemp = temperatures[0, 0];

        int hottestDayIndex = 0;
        int coldestDayIndex = 0;

        // Calculate averages and find hottest/coldest day
        for (int day = 0; day < 7; day++)
        {
            float dailySum = 0;

            for (int hour = 0; hour < 24; hour++)
            {
                float currentTemp = temperatures[day, hour];
                dailySum += currentTemp;

                if (currentTemp > hottestTemp)
                {
                    hottestTemp = currentTemp;
                    hottestDayIndex = day;
                }

                if (currentTemp < coldestTemp)
                {
                    coldestTemp = currentTemp;
                    coldestDayIndex = day;
                }
            }

            Console.WriteLine("Average temperature of Day " + (day + 1) + " = " + (dailySum / 24));
        }

        Console.WriteLine("Hottest Day: Day " + (hottestDayIndex + 1));
        Console.WriteLine("Coldest Day: Day " + (coldestDayIndex + 1));
    }


    static void StudentScores()
    {
        Console.WriteLine("Enter number of students:");
        int studentCount = int.Parse(Console.ReadLine());

        int[] studentScores = new int[studentCount];
        int totalScore = 0;

        // Input scores
        for (int index = 0; index < studentCount; index++)
        {
            Console.WriteLine("Enter score for student " + (index + 1));
            int score = int.Parse(Console.ReadLine());

            if (score < 0)
            {
                Console.WriteLine("Invalid score. Enter again.");
                index--;
                continue;
            }

            studentScores[index] = score;
            totalScore += score;
        }

        int highestScore = studentScores[0];
        int lowestScore = studentScores[0];

        // Find highest and lowest
        for (int index = 1; index < studentCount; index++)
        {
            if (studentScores[index] > highestScore)
                highestScore = studentScores[index];

            if (studentScores[index] < lowestScore)
                lowestScore = studentScores[index];
        }

        float averageScore = totalScore / (float)studentCount;

        Console.WriteLine("Average Score: " + averageScore);
        Console.WriteLine("Highest Score: " + highestScore);
        Console.WriteLine("Lowest Score: " + lowestScore);

        Console.WriteLine("Scores above average:");
        for (int index = 0; index < studentCount; index++)
        {
            if (studentScores[index] > averageScore)
                Console.WriteLine(studentScores[index]);
        }
    }

    // MAIN METHOD 
    static void Main(string[] args)
    {
       
        Console.WriteLine("1. Temperature Analyzer");
        Console.WriteLine("2. Student Score Analyzer");

        int menuChoice = int.Parse(Console.ReadLine());

        switch (menuChoice)
        {
            case 1:
                TemperatureAnalyzer();
                break;

            case 2:
                StudentScores();
                break;
        }
    }
}
