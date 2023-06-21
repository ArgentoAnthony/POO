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
        private int _prix;
        public Vehicule(string marque, decimal prix)
        {
            Marque = marque;
            Prix = prix;
        }
        //public Vehicule()
        //{
        //    Id = _id++;
        //}
        public int Id { get; set; }
        public string Marque { get; set; }
        public decimal Prix
        {
            get { return _prix; }
            set
            {
                if (value < 0)
                {
                   throw new ArgumentOutOfRangeException("Le prix doit etre positif");
                }
                if(value == 5)
                {
                    throw new NotFiveException();
                }
                _prix = (int)value;
            }
        }
        public abstract void Deplacer();
        // Sera forcément utilisée par les enfants

        public override string ToString()
        {
            return $"{Id} : {Marque} : {Prix}";
        }
    }
}
