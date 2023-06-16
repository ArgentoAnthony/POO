using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReexplicationBanque.Models
{
    public class Banque
    {
        //<string, Courant> numéro de compte, string en tant que clé. Courant est la valeur
        private Dictionary<string, Courant> _comptes;

        public Dictionary<string, Courant> Comptes
        {
            get
            {
                //// Si compte est null, création d'un nouveau
                //if(_comptes is null)
                //{
                //    return new Dictionary<string, Courant>();
                //}
                //return _comptes;
                //return _comptes = _comptes ?? new Dictionary<string, Courant>();

                // Tout le dessus veut dire exactement la meme chose que cette ligne
                return _comptes ??= new Dictionary<string, Courant>();
            }
        }
        public string Name { get; set; }

        public Courant this[string numero]
        {
            get
            {
                Comptes.TryGetValue(numero, out Courant c);
                return c;
            }
        }

        public void Ajouter(Courant c)
        {
            Comptes.Add(c.Numero, c);
        }

        public void Supprimer(string numero)
        {
            Comptes.Remove(numero);
        }

        public decimal AvoirDesComptes(Personne p)
        {
            decimal somme = 0;
            foreach (Courant c in Comptes.Values)
            {
                if (p == c.Titulaire)
                {
                    somme += c;
                }
            }
            return somme;
        }
    }
}