namespace OpenClose
{
    public class EmployeeFullTime : IEmployee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public EmployeeFullTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public decimal CalculateSalaryMonthly()
        {
            return GetHourValue() * HoursWorked;
        }

        public decimal GetHourValue()
        {
            return 30000M;
        }
    }
}