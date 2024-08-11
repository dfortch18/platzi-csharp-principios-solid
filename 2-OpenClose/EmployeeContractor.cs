namespace OpenClose
{
    public class EmployeeContractor : IEmployee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public EmployeeContractor(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public decimal CalculateSalaryMonthly()
        {
            return GetHourValue() * HoursWorked;
        }

        protected decimal GetHourValue()
        {
            return 20000M;
        }

        decimal IEmployee.GetHourValue()
        {
            throw new NotImplementedException();
        }
    }
}