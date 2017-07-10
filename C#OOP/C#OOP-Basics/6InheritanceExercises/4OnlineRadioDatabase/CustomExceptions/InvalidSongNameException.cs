using System;
using System.Runtime.Serialization;

public class InvalidSongNameException : InvalidSongException
{
    public InvalidSongNameException()
    {
    }

    public InvalidSongNameException(string message) : base(message)
    {
    }

    public InvalidSongNameException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected InvalidSongNameException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

