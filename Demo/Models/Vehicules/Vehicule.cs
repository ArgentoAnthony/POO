using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models.Vehicules
{
    public abstract class Vehicule
    {
        private static int _id = 1;

        public Vehicule()
        {
            Id = _id++;
        }
        public int Id { get; set; }
        public string Marque { get; set; }
        public decimal Prix { get; set; }
        public abstract void Deplacer();
        // Sera forcément utilisée par les enfants

        public override string ToString()
        {
            return $"{Id} : {Marque} : {Prix}";
        }
    }
}
