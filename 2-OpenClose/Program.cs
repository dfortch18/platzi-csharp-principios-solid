using OpenClose;

var employees = new List<IEmployee>() {
    new EmployeeContractor("Manuel Perez", 200),
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeePartTime("Manuel Lopera", 180)
};

foreach (var employee in employees)
{
    Console.WriteLine($"Empleado: {employee.Fullname} Pago: {employee.CalculateSalaryMonthly():C2}");
}
