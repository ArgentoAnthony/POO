using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo.Models.Vehicules
{
    public class Amphibie : Voiture, IBateau
    {
        public Amphibie(string marque, decimal prix, string couleur) : base(marque, prix, couleur)
        {
        }

        public void Navigue()
        {
            throw new NotImplementedException();
        }
        public void Tourne()
        {
            throw new NotSupportedException();
        }
    }
}
