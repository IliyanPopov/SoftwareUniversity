using System;
using System.Runtime.Serialization;

public class InvalidSongSecondsException : InvalidSongLengthException
{
    public InvalidSongSecondsException()
    {
    }

    public InvalidSongSecondsException(string message) : base(message)
    {
    }

    public InvalidSongSecondsException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected InvalidSongSecondsException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

