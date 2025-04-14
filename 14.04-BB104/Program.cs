using _14._04_BB104.Exceptions;
using _14._04_BB104.Helpers;
using _14._04_BB104.Models;

namespace _14._04_BB104
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GroupManager groupManager = new();

           



            Student student1 = new("Emiliya", "Zeynalzada", 12, "ASLDKM");
            Student student2 = new("Sekine", "ELiyeva", 21, "AJKDSA");
            Student student3 = new("Gulyana", "Xelilova", 20, "ASKDM");


            List<Student> students = [student1, student2, student3];

            Group group = new("BB104", students);

            groupManager.Add(group);

            groupManager.Delete(1);

            groupManager.PrintAll();

            groupManager.GetById(1);
        }
    }
}
