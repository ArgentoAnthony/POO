using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRougeBanque.Models
{
    internal class Epargne: Compte
    {
        public DateTime DateDernierRetrait {get; set;}
        public void Retrait(decimal montant)
        {
            decimal ancienSolde = Solde;
            base.Retrait(montant);
            if (ancienSolde > Solde)
            {
                DateDernierRetrait = DateTime.Now;
            }
        }
    }
}
