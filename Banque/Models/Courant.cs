using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FilRougeBanque.Models
{
    public class Courant : Compte
    {
        private decimal _ligneDeCredit;

        public Courant(string numero, Personne titulaire) : base(numero, titulaire) { }
        public Courant(string numero, Personne titulaire, decimal solde) : base(numero, titulaire,solde) { }    
        public Courant(string numero, decimal ligneDeCredit, Personne titulaire) : base(numero, titulaire)
        {
            LigneDeCredit = ligneDeCredit;
        }

        public decimal LigneDeCredit
        {
            get
            {
                return _ligneDeCredit;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("La ligne de crédit est inférieure à 0");
                }
                _ligneDeCredit = value;
            }
        }

        public override void Retrait(decimal montant)
        {
            Retrait(montant, LigneDeCredit);
        }
        protected override decimal CalculInteret()
        {
            //if (Solde >= 0)
            //{
            //    return Solde * 0.03M;
            //}
            //return Solde * 0.975M;

            return Solde * (Solde >= 0 ? .03M : 0.975M);
        }

    }
}
