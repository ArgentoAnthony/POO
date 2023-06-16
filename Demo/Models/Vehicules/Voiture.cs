using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models.Vehicules
{
    public class Voiture : Vehicule
    {
        public string Couleur { get; set; }
        public override void Deplacer()
        {
            Console.WriteLine("Et je roule roule");
        }
        public override string ToString()
        {
            return base.ToString() + $" : {Couleur}";
        }
        public void Tourne()
        {
            Console.WriteLine("Je tourne le volant");
        }
    }
}
