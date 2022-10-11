using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7LSP
{
    public class ExceptionBase : Exception
    {
        public ExceptionBase()
            : base()
        {
        }

        public ExceptionBase(string message)
            : base(message)
        {
        }
    }

    public class EntityNotFoundException : ExceptionBase
    {
    }

    public class UserNotFoundException : ExceptionBase
    {
        public UserNotFoundException()
            : base()
        {
        }

        public UserNotFoundException(string message)
            : base(message)
        {
        }
    }
}
