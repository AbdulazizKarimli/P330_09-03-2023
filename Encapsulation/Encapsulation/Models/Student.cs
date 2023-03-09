namespace Encapsulation.Models;

public class Student
{
    //public string name;
    public string Name { get; } = "asdfds"; //readonly prop
    //public readonly string name = "sada";
    public string Surname { get; init; }
    public string Name1 { get; private set; }
    public string GroupNo { get; set; }
    private byte _age;
    private int _point;

    public const string test = "asd";

    public Student()
    {
        //name = "ASfdsf";
    }

    public byte Age
    {
        get
        {
            return _age;
        }
        set
        {
            if (value >= 6)
                _age = value;
            else
                _age = 6;
        }
    }

    public int Point
    {
        get => _point;
        set
        {
            if (value > 0)
                _point = value;
        }
    }

    //public void Test()
    //{
    //    Name1 = "awsda";
    //}

//    public void SetAge(byte age)
//    {
//        if (age >= 6)
//            _age = age;
//        else
//            _age = 6;
//    }

//    public byte GetAge()
//    {
//        return _age;
//    }
}