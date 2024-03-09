using eLSC.Domain.Exceptions;

namespace eLSC.Domain.ValueObjects;

public class MassNumber
{
    public int Value {get; private set; }
    
    public MassNumber(int value)
    {
        if (value < 1 || value > 294)
        {
            throw new InvalidMassNumberException(value);
        }
        this.Value = value;
    }

    public static implicit operator int(MassNumber massNumber) => massNumber.Value;

    public static implicit operator MassNumber(int value) => new(value);
}