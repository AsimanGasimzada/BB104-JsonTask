using _14._04_BB104.Models.Common;

namespace _14._04_BB104.Models;
public class Student : BaseEntity
{
    private static int _id = 1;
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Code { get; set; }
    public Student(string name, string surname, int age, string code) : base(_id++)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Code = code;
    }

    public override string ToString()
    {
        return $"{Id}. {Name} {Surname}  {Code}  {Age}";
    }
}
