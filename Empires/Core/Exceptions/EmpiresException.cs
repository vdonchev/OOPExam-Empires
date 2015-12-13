namespace Empires.Core.Exceptions
{
    using System;

    public class EmpiresException : Exception
    {
        public EmpiresException(string message)
            : base(message)
        {
        }
    }
}