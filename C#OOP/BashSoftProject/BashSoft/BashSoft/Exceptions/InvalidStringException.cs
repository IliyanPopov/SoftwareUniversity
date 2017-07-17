
namespace BashSoft.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    public class InvalidStringException : Exception
    {
        private const string NullOrEmptyValue = "NullOrEmptyValue";
        public InvalidStringException()
            : base(NullOrEmptyValue)
        {
        }

        public InvalidStringException(string message) : base(message)
        {
        }
    }
}
