using System;
using System.Runtime.Serialization;

public class InvalidSongLengthException : InvalidSongException
{
    public InvalidSongLengthException()
    {
    }

    public InvalidSongLengthException(string message) : base(message)
    {
    }

    public InvalidSongLengthException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected InvalidSongLengthException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

