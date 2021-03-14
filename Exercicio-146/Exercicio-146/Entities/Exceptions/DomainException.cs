using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_146.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException (string message) : base(message)
        {

        }
    }
}
