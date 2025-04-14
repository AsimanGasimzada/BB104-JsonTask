namespace _14._04_BB104.Models.Common;
public abstract class BaseEntity
{
    public int Id { get; set; }
    protected BaseEntity(int id)
    {
        Id = id;
    }
}
