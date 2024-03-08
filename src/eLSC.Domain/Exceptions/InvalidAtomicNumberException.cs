namespace eLSC.Domain.Exceptions;

public sealed class InvalidAtomicNumberException : Exception
{
    public int Value { get; private set; }

    public InvalidAtomicNumberException(int value) : base($"Atomic number {value} is invalid.")
    {
        this.Value = value;
    }
}