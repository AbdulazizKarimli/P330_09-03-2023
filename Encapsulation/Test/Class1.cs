using Encapsulation.Models;

namespace Test
{
    public class Class1 : Person
    {
        public Class1()
        {
            Surname = "SAd";
            //Name = "asd";
            Person person = new();
            person.Surname = "asd";
            //person.Name = "asd";
        }
    }
}