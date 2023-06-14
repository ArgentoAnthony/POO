using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public enum Race
    {
        Humain,
        Nain
    }
    public partial class Entity
    {

        #region Attributs

        private string _name;

        private Stats _stats = new Stats();

        #endregion


        #region Constructeurs

        public Entity(string name)
        {
            Random r = new Random();
            Name = name;
            Stats[StatType.Hp] = r.Next(5, 10);
            Stats[StatType.Strength] = r.Next(5, 10);
            Stats[StatType.Stamina] = r.Next(5, 10);
        }

        #endregion

        #region Propriétés

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Trim() == "")
                {
                    return;
                }
                _name = value.Trim();
            }
        }

        public Stats Stats { get { return _stats; } }


        #endregion

        #region Methodes

        public override string ToString()
        {
            return $"Nom : {Name}\n" +
                   $"Pv : {Stats[StatType.Hp]}\n" +
                   $"Endurance : {Stats[StatType.Stamina]}\n";
        }

        #endregion
    }
}
