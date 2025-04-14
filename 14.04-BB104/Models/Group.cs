using _14._04_BB104.Models.Common;

namespace _14._04_BB104.Models;

public class Group : BaseEntity
{
    private static int _id = 1;
    public string Name { get; set; }
    public List<Student> Students { get; set; } = [];
    public Group(string name, List<Student> students) : base(_id++)
    {
        Name = name;
        Students = students;
    }


    public override string ToString()
    {
        return $"{Id}. {Name}  {Students.Count} Students";

    }
}