namespace Models
{
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(int hourlyRate, int hoursWorked)
            : base(hourlyRate, hoursWorked)
        {
        }

        public override int CalculateWage()
        {
            return HourlyRate * HoursWorked;
        }
    }
}
