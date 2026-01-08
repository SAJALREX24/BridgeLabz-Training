using System;

namespace Utilities
{
    public class EmployeeUtility : IEmployeeUtility
    {
        public bool CheckEmployeeAttendance()
        {
            Random attendanceGenerator = new Random();
            return attendanceGenerator.Next(0, 2) == 1;
        }

        public int CalculateMonthlyWage(int dailyPay, int totalWorkingDays)
        {
            return dailyPay * totalWorkingDays;
        }

     
        public int CalculateFullTimeWage(int hourlyRate, int hoursWorked)
        {
            return hourlyRate * hoursWorked;
        }

      
        public int CalculatePartTimeWage(int hourlyRate, int hoursWorked)
        {
            return hourlyRate * hoursWorked;
        }

        public int CalculateWageTillCondition(int hourlyRate, int maxAllowedHours, int maxAllowedDays)
        {
            int accumulatedHours = 0;
            int accumulatedDays = 0;

            while (accumulatedHours < maxAllowedHours && accumulatedDays < maxAllowedDays)
            {
                Console.Write($"Enter working hours for day {accumulatedDays + 1}: ");
                int dailyHours = Convert.ToInt32(Console.ReadLine());

                accumulatedHours += dailyHours;
                accumulatedDays++;
            }

            return accumulatedHours * hourlyRate;
        }
    }
}
