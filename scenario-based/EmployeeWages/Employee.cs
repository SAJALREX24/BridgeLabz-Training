namespace Models
{
    public abstract class Employee
    {
        protected int HourlyRate;
        protected int HoursWorked;

        protected Employee(int hourlyRate, int hoursWorked)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked; 
        }

        public abstract int CalculateWage();
    }
}
