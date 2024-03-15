using eLSC.Domain.Entities;

namespace eLSC.Domain.ValueObjects;

public class Energy
{
    private double Value { get; }
    public Energy(double value)
    {
        if(value < 0.0) 
        {
            throw new InvalidEnergyException(value);
        }
        this.Value = value;
    }

    
}
