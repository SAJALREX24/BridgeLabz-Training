namespace Utilities
{
    public interface IEmployeeUtility
    {
        bool CheckEmployeeAttendance();
        int CalculateMonthlyWage(int dailyPay, int totalWorkingDays);
        int CalculateWageTillCondition(int hourlyRate, int maxAllowedHours, int maxAllowedDays);
    }
}
