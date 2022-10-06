using System;

namespace Ch4Test.DomainIF.Exceptions
{
    public class ServiceException : ExceptionBase
    {
        public ServiceException()
        {

        }
        public ServiceException(string message) : base(message)
        {
        }

        public ServiceException(string message, Exception exception) : base(message, exception)
        {
        }

        public override ExceptionKind Kind => ExceptionKind.Error;
    }
}