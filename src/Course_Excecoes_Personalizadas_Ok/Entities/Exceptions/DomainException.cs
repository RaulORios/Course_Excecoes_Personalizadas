using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Excecoes_Personalizadas_Ok.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
