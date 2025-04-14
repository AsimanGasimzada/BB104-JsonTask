using _14._04_BB104.Exceptions;
using _14._04_BB104.Models;
using Newtonsoft.Json;

namespace _14._04_BB104.Helpers;
public class GroupManager
{
    private List<Group> _groups;
    public List<Group> Groups
    {
        get
        {

            _groups = ReadFromJson();
            return _groups;

        }
        set
        {
            _groups = value;
            WriteToJson(_groups);
        }
    }
    private string _path = "../../../Jsons/groups.json";
    public GroupManager()
    {
        if (!File.Exists(_path))
        {

            File.Create(_path).Close();
        }
    }


    public void Add(Group group)
    {
        var isExist = Groups.Any(x => x.Id == group.Id);

        if (isExist)
            throw new AlreadyExistException("this group is already exist");

        _groups = ReadFromJson();

        _groups.Add(group);
        WriteToJson(_groups);


        Console.WriteLine("Successfully added");

    }


    public void Delete(int id)
    {
        var existGroup = Groups.FirstOrDefault(x => x.Id == id);

        if (existGroup is null)
            throw new NotFoundException();

        _groups = ReadFromJson();

        _groups.Remove(existGroup);
        WriteToJson(_groups);

        Console.WriteLine("Successfully removed");
    }




    public void PrintAll() => Groups.ForEach(group => Console.WriteLine(group));


    public void GetById(int id)
    {
        var group = Groups.FirstOrDefault(x => x.Id == id);

        if (group is null)
            throw new NotFoundException();

        Console.WriteLine(group);
        Console.WriteLine();
        Console.WriteLine("------------------");

        group.Students.ForEach(student => Console.WriteLine(student));

    }


    private void WriteToJson(List<Group> items)
    {
        var json = JsonConvert.SerializeObject(items);

        using StreamWriter sw = new(_path);

        sw.Write(json);

    }

    private List<Group> ReadFromJson()
    {
        using StreamReader sr = new(_path);

        var json = sr.ReadToEnd();

        var data = JsonConvert.DeserializeObject<List<Group>>(json) ?? new();

        return data;
    }
}
