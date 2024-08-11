namespace Liskov
{
    public abstract class Employee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public  Employee(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public virtual decimal CalculateSalary()
        {
            return GetHourValue() * HoursWorked;
        }

        public abstract int GetHourValue();
    }
}