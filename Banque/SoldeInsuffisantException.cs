using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRougeBanque
{
    public class SoldeInsuffisantException : Exception
    {
        public SoldeInsuffisantException() : base("Votre solde est insuffisant pour ce retrait") { }

        public SoldeInsuffisantException(string? message) : base(message) { }

    }
}
