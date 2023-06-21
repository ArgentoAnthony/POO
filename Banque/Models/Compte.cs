using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FilRougeBanque.Models
{
    public abstract class Compte : ICustomer, IBanker
    {
        public Compte(string numero, Personne titulaire)
        {
            Numero = numero;
            Titulaire = titulaire;
        }
        public Compte(string numero, Personne titulaire, decimal solde) : this(numero, titulaire)
        {
            Solde = solde;
        }

        public string Numero { get;private set; }

        public decimal Solde { get; private set; }

        public Personne Titulaire { get;private set; }

        public virtual void Retrait(decimal montant)
        {
            Retrait(montant, 0);
        }

        protected void Retrait(decimal montant, decimal ligneDeCredit)
        {
            if (montant < 0)
            {
                return;
            }
            if (Solde - montant < -ligneDeCredit)
            {
                throw new SoldeInsuffisantException("Vous etes trop pauvre pour retirer autant");
            }
            Solde -= montant;
        }

        public void Depot(decimal montant)
        {
            if (montant < 0)
            {
                throw new ArgumentOutOfRangeException("Le dépôt doit être positif");
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
