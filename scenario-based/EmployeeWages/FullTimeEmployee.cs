namespace Models
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(int hourlyRate, int hoursWorked)
            : base(hourlyRate, hoursWorked)
        {
        }

        public override int CalculateWage()
        {
            return HourlyRate * HoursWorked;
        }
    }
}
