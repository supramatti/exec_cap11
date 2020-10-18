using System;

namespace exec_cap11_fix.Entities.Exceptions
{
    class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) :base(message)
        {
        }
    }
}
