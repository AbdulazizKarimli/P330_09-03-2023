namespace Homework.Models;

public class Student : Person
{
    private byte _point;

    public byte Point 
    {
        get => _point;
        set
        {
            if(value >= 0 && value <= 100)
                _point = value;
        }
    }

    public Student(string name, byte age, byte point) : base(name, age)
    {
        Point = point;
    }
}
