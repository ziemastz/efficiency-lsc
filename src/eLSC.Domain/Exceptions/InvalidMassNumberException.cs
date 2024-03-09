namespace eLSC.Domain.Exceptions;

public sealed class InvalidMassNumberException : Exception
{
    public int Value { get; private set; }
    public InvalidMassNumberException(int value)
        : base($"Mass number {value} is invalid.")
    {
        this.Value = value;
    }
}