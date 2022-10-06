namespace Ch4Test.DomainIF.Exceptions
{
    public class DomainException : ExceptionBase
    {
        public DomainException()
        {
        }

        public DomainException(string message) : base(message)
        {
        }

        public override ExceptionKind Kind => ExceptionKind.Error;
    }
}