namespace eLSC.Domain.Entities;

public class Nuclide : BaseEntity
{
    public int AtomicNumber { get; private set; }
    public int MassNumber { get; private set; }

    public Nuclide(int id, int atomicNumber, int massNumber) 
    : base(id)
    {
        this.AtomicNumber = atomicNumber;
        this.MassNumber = massNumber;
    }
}