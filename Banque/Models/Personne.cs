using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FilRougeBanque.Models
{
    public class Personne
    {
        public Personne(string nom, string prenom, DateTime datenaiss) 
        { 
            Nom = nom;
            Prenom = prenom;
            DateNaiss = datenaiss;
        }

        public string Nom { get;private set; }

        public string Prenom { get;private set; }

        public DateTime DateNaiss { get; private set; }
        public static bool operator ==(Personne p1, Personne p2)
        {
            return p1.Nom == p2.Nom && p1.Prenom == p2.Prenom && p1.DateNaiss == p2.DateNaiss;
        }

        public static bool operator !=(Personne p1, Personne p2)
        {
            return !(p1 == p2);
        }
    }
}
