using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReexplicationBanque.Models
{
    public class Epargne : Compte
    {
        public DateTime DateDernierRetrait { get; private set; }

        public override void Retrait(decimal montant)
        {
            decimal ancienSolde = Solde;
            // Appel de la méthode retrait de la classe parent (Compte)
            base.Retrait(montant);
            if(Solde < ancienSolde)
            {
                DateDernierRetrait = DateTime.Now;
            }
        }
    }
}
