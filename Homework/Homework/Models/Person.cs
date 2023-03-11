namespace Homework.Models;

public class Person
{
    private string _name;
    private string _surname;

    public string Name 
    {
        get => _name;
        set
        {
            if(CheckString(value, 3, 30))
                _name = value;
        }
    }
    public string Surname
    {
        get => _surname;
        set
        {
            if (CheckString(value, 3, 35))
                _surname = value;
        }
    }
    public byte Age { get; set; }

    public Person(string name, byte age)
    {
        Name = name;
        Age = age;
    }

    private bool CheckString(string str, int minLength, int maxLength)
    {
        return !string.IsNullOrWhiteSpace(str)
            && char.IsUpper(str[0]) 
            && str.Length >= minLength 
            && str.Length <= maxLength;
    }
}
