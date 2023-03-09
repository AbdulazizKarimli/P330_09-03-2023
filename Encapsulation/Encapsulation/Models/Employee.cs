namespace Encapsulation.Models;

public class Employee
{
    public string name;
    public int salary;

    public Employee(string name, int salary)
    {
        this.name = name;
        this.salary = salary;
    }

    public string ShowInfo()
    {
        return $"{name} - {salary}";
    }
}