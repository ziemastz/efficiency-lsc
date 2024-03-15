using System.Runtime.Serialization;

namespace eLSC.Domain.ValueObjects;

[Serializable]
internal class InvalidEnergyException : Exception
{
    private double value;

    public InvalidEnergyException()
    {
    }

    public InvalidEnergyException(double value)
    {
        this.value = value;
    }

    public InvalidEnergyException(string? message) : base(message)
    {
    }

    public InvalidEnergyException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected InvalidEnergyException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}