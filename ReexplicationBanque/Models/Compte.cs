using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReexplicationBanque.Models
{
    public class Compte
    {
        
        #region Propriétés      
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
        public virtual void Retrait(decimal montant) // virtual permet de pouvoir les réécrire dans les enfants
        {
            //Si on arrive ici dans le code c'est que le retrait ne prend pas en compte de limite (ligne de credit)
            // du coup on fixe la limite à 0
            Retrait(montant, 0);
        }

        public void Retrait(decimal montant, decimal limite)
        {
            if (montant < 0)
            {
                return;
            }
            if (Solde - montant < -limite)
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

        //Surcharge de l'operateur +
        // Nous permet maintenant d'additionner un décimal avec un compte sans plus jamais spécifier le solde 

        public static decimal operator +(decimal somme, Courant courant)
        {
            //if(courant.Solde < 0)
            //{
            //    return somme;
            //}
            //return somme + courant.Solde;
            // On prend en compte le Solde que si il est positif
            return somme + courant.Solde <= 0 ? 0 : courant.Solde;
        }


        #endregion
    }
}
