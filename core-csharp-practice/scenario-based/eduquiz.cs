 /*"EduQuiz – Student Quiz Grader"
Story: You’re building the grading module for a quiz app. A student answers a 10-question quiz.
You must compare their answers to the correct ones, give feedback, and calculate scores.
Requirements:
● Use two String[] arrays: correctAnswers[] and studentAnswers[].
● Implement a method calculateScore(String[] correct, String[]
student) that returns a score.
● Use string comparison with .equalsIgnoreCase() for case-insensitive matching.
● Print detailed feedback: Question 1: Correct / Incorrect.
● Bonus: Show percentage score and pass/fail message.
 */
using System;

class EduQuiz
{
    // Method to calculate score
    static int CalculateScore(string[] correct, string[] student)
    {
        int score = 0;

        for (int i = 0; i < correct.Length; i++)
        {
            if (student[i].Equals(correct[i], StringComparison.OrdinalIgnoreCase))
            {
                score++;
            }
        }
        return score;
    }

    static void Main()
    {
        // Correct answers
        string[] correctAnswers =
        {"A", "C", "B", "D", "A","B", "C", "D", "A", "B"};

        // Student answers
        string[] studentAnswers =
        {"a", "C", "b", "A", "A","B", "d", "D", "A", "c"};

        Console.WriteLine("EduQuiz");
       

        // Detailed feedback
        for (int i = 0; i < correctAnswers.Length; i++)
        {
            if (studentAnswers[i].Equals(correctAnswers[i], StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Question "+(i + 1)+" : Correct");
            }
            else
            {
                Console.WriteLine("Question "+(i + 1)+" : Incorrect");
            }
        }

        // Calculate score
        int score = CalculateScore(correctAnswers, studentAnswers);

        // Percentage
        double percentage = (score / (double)correctAnswers.Length) * 100;

        Console.WriteLine("Score: "+((score)/(correctAnswers.Length)));
        Console.WriteLine("Percentage: "+(percentage)+" %");

        // Pass / Fail
        if (percentage >= 50)
        {
            Console.WriteLine("Result: PASS ");
        }
        else
        {
            Console.WriteLine("Result: FAIL ");
        }
    }
}
