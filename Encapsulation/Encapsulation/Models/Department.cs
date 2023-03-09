namespace Encapsulation.Models;

public class Department
{
    public string name;
    public int employeeLimit;
    private Employee[] employees;

    public Department(string name, int employeeLimit)
    {
        this.name = name;
        this.employeeLimit = employeeLimit;
        employees = new Employee[0];
    }

    public void AddEmployee(Employee employee)
    {
        if(employees.Length < employeeLimit)
        {
            Array.Resize(ref employees, employees.Length + 1);
            employees[employees.Length - 1] = employee;
        }
    }

    public Employee[] GetAllEmployees()
    {
        return employees;
    }

    public Employee SearchByName(string name)
    {
        foreach (var employee in employees)
        {
            if (employee.name == name)
                return employee;
        }

        return null;
    }

    public string ShowInfo()
    {
        return $"{name} - {employees.Length} - {employeeLimit}";
    }
}