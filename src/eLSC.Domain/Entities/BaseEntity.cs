namespace eLSC.Domain.Entities;

public class BaseEntity
{
    public int Id { get; private set; }

    public BaseEntity(int Id)
    {
        this.Id = Id;
    }

}