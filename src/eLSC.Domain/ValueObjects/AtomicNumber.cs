using eLSC.Domain.Exceptions;

namespace eLSC.Domain.ValueObjects;

public sealed class AtomicNumber
{
    public int Value { get; private set; }

    public AtomicNumber(int value)
    {
        if (value is 1 < or > 10)
        {
            throw new InvalidAtomicNumberException(value);
        }

        this.Value = value;
    }

    public static implicit operator int(AtomicNumber atomicNumber) => atomicNumber.Value;

    public static implicit operator AtomicNumber(int value) => new(value);
}