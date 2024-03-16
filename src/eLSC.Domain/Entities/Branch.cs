namespace eLSC.Domain.Entities;

public class Branch : BaseEntity
{
    public Branch(int id)
    : base(id)
   {
   }

   public IEnumerable<double> Energies { get; set; }
}