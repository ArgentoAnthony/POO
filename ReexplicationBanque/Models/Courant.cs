using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReexplicationBanque.Models
{
    public class Courant : Compte
    {
        #region Attributs
        private decimal _ligneDeCredit;
        #endregion
        public decimal LigneDeCredit
        {
            get
            {
                return _ligneDeCredit;
            }
            set
            {
                // value est un mot clef qui désigne la valeur qu'on essaiera d'affecter
                // à la variable au moment de l'utilisation
                if (value < 0)
                {
                    return;
                }
                _ligneDeCredit = value;
            }
        }

        public override void Retrait(decimal montant)
        {
            // Appel de la surcharge de la methode retrait de la classe parent (Compte)
            // etant donné que la surcharge n'est pas virtuelle et jamais override, le base. n'est pas obligatoire
            base.Retrait(montant, LigneDeCredit); 
        }
    }
}
