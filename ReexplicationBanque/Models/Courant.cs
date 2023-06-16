using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReexplicationBanque.Models
{
    public class Courant
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
            if (Solde - montant < -LigneDeCredit)
            {
                return;
            }
            Solde -= montant;
        }

        public override string ToString()
        {
            return $"Numero : {Numero}\n" +
                   $"Titulaire : {Titulaire.Prenom}" +
                   $"___________________________________________";
        }
        public static decimal operator +(Courant a, Courant b)
        {
            //Courant result = new Courant();
            //result.Solde = a.Solde + b.Solde;
            //return result;
            return a.Solde + b.Solde;
        }

        public static decimal operator +(decimal somme, Courant c)
        {
            return somme + c.Solde > 0 ? c.Solde : 0;
        }


        #endregion
    }
}
