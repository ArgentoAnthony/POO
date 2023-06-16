using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FilRougeBanque.Models
{
    public abstract class Compte
    {
        public string Numero { get; set; }

        public decimal Solde { get; private set; }

        public Personne Titulaire { get; set; }

        public virtual void Retrait(decimal montant)
        {
            Retrait(montant, 0);
        }

        public void Retrait(decimal montant, decimal ligneDeCredit)
        {
            if (montant < 0)
            {
                return;
            }
            if (montant - Solde < -ligneDeCredit)
            {

            }
            Solde -= montant;
        }

        public void Depot(decimal montant)
        {
            if (montant < 0)
            {
                return;
            }
            Solde += montant;
        }

        public static decimal operator +(Compte c1, Compte c2)
        {
            return c1.Solde + c2.Solde;
        }

        public static decimal operator +(decimal somme, Compte c)
        {
            //if(c.Solde > 0)
            //{
            //    return somme + c.Solde;
            //}
            //else
            //{
            //    return somme + 0;
            //}
            return somme + (c.Solde > 0 ? c.Solde : 0);
        }

        protected abstract decimal CalculInteret();

        public void AppliquerInteret()
        {
            Solde += CalculInteret();
        }



    }
}
