using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models.Vehicules
{
    public class Garage
    {
        public string Name { get; set; }
        public List<Vehicule> Vehicules { get; set; }
        public Vehicule this[int id]
        {
            get
            {
                return Vehicules.SingleOrDefault(v => v.Id == id);
            }
        }

        public Garage()
        {
            Vehicules = new List<Vehicule>();
        }
        public Garage(string name) : this()
        {
            Name = name;
        }
    }
}
