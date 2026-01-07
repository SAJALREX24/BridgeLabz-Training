using System;

namespace UI
{
    public class EmployeeUI
    {
        public static void StartApplication()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("   Employee Wage Computation System   ");
            Console.WriteLine("=========================================\n");

            EmployeeMenu.ShowMenu();
        }
    }
}
