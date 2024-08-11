namespace Liskov
{
    public class EmployeeFullTime : Employee
    {
        public int ExtraHours { get; set; }

        public EmployeeFullTime(string fullname, int hoursWorked, int extrahours) : base(fullname, hoursWorked)
        {
            ExtraHours = extrahours;
        }

        public override decimal CalculateSalary()
        {
            return GetHourValue() * (HoursWorked + ExtraHours);
        }

        public override int GetHourValue()
        {
            return 50;
        }
    }
}