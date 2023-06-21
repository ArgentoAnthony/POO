using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models.Vehicules
{
    public class Avion : Vehicule
    {
        public Avion(string marque, decimal prix) : base(marque, prix)
        {
        }

        public int Speed { get; set; }
        public override void Deplacer()
        {
            Console.WriteLine("Je m'enfuis pas je vooooole");
        }
        public override string ToString()
        {
            return base.ToString() + $" : {Speed}";
        }
    }
}
