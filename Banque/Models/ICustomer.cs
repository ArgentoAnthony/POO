using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRougeBanque.Models
{
    public interface ICustomer
    {
        decimal Solde { get; }

        void Retrait(decimal montant);
        void Depot(decimal montant);
    }
}
