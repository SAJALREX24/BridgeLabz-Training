using System;
using Models;
using Utilities;

namespace UI
{
    public class EmployeeMenu
    {
        public static void ShowMenu()
        {
            EmployeeUtility employeeUtility = new EmployeeUtility();

            Console.WriteLine("1. UC1 - Check Employee Attendance");
            Console.WriteLine("2. UC2 - Calculate Full Time Wage");
            Console.WriteLine("3. UC3 - Calculate Part Time Wage");
            Console.WriteLine("4. UC5 - Calculate Monthly Wage");
            Console.WriteLine("5. UC6 - Calculate Wage Till Condition");
            Console.WriteLine("0. Exit\n");

            Console.Write("Enter your choice: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine(
                        employeeUtility.CheckEmployeeAttendance()
                        ? "Employee is Present"
                        : "Employee is Absent"
                    );
                    break;

                case 2:
                    Console.Write("Enter Hourly Rate: ");
                    int fullTimeRate = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Working Hours: ");
                    int fullTimeHours = Convert.ToInt32(Console.ReadLine());

                    Employee fullTimeEmployee = new FullTimeEmployee(fullTimeRate, fullTimeHours);
                    Console.WriteLine("Full Time Daily Wage: " + fullTimeEmployee.CalculateWage());
                    break;

                case 3:
                    Console.Write("Enter Hourly Rate: ");
                    int partTimeRate = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Working Hours: ");
                    int partTimeHours = Convert.ToInt32(Console.ReadLine());

                    Employee partTimeEmployee = new PartTimeEmployee(partTimeRate, partTimeHours);
                    Console.WriteLine("Part Time Daily Wage: " + partTimeEmployee.CalculateWage());
                    break;

                case 4:
                    Console.Write("Enter Daily Pay: ");
                    int dailyPay = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Total Working Days: ");
                    int totalDays = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(
                        "Monthly Wage: " +
                        employeeUtility.CalculateMonthlyWage(dailyPay, totalDays)
                    );
                    break;

                case 5:
                    Console.Write("Enter Hourly Rate: ");
                    int hourlyRate = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Max Allowed Hours: ");
                    int maxHours = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Max Allowed Days: ");
                    int maxDays = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(
                        "Total Wage Till Condition: " +
                        employeeUtility.CalculateWageTillCondition(hourlyRate, maxHours, maxDays)
                    );
                    break;

                case 0:
                    Console.WriteLine("Thank You!");
                    return;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }

            Console.WriteLine("\n-----------------------------------------\n");
            ShowMenu();
        }
    }
}
