using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReexplicationBanque.Models
{
    internal class Courant
    {
        #region Attributs
        private decimal _ligneDeCredit;
        #endregion

        #region Propriétés
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
       
        public string Numero { get; set; }
        public decimal Solde { get; private set; }

        public Personne Titulaire { get; set; }

        #endregion

        #region méthodes

        public void Depot(decimal montant)
        {
            if (montant < 0)
            {
                return;
            }
            Solde += montant;
        }

        public void Retrait(decimal montant)
        {
            if (montant < 0)
            {
                return;
            }
            if(Solde - montant < -LigneDeCredit)
            {
                return;
            }
            Solde-= montant;
        }

        #endregion
    }
}
