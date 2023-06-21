using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class NotFiveException : Exception
    {
        public NotFiveException() : base("Je ne veux pas 5!") { }

        public NotFiveException(string? message) : base(message) { }
    }
}
