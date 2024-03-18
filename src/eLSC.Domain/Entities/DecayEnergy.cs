namespace eLSC.Domain.Entities;

public class DecayEnergy : BaseEntity
{
    public DecayEnergy(int eventId)
        : base(eventId)
    {
    }

    public IEnumerable<Branch> Branches { get; set;}
}
