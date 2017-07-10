using System;
using System.Runtime.Serialization;

public class InvalidSongMinutesException : InvalidSongLengthException
{
    public InvalidSongMinutesException()
    {
    }

    public InvalidSongMinutesException(string message) : base(message)
    {
    }

    public InvalidSongMinutesException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected InvalidSongMinutesException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

