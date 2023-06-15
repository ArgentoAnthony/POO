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

        public Entity() { }

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

        public static Entity operator +(Entity a, Entity b)
        {
            Entity result = new Entity();
            result.Name = a.Name +b.Name;
            result.Stats[StatType.Hp] = a.Stats[StatType.Hp] + b.Stats[StatType.Hp];
            result.Stats[StatType.Strength] = a.Stats[StatType.Strength] + b.Stats[StatType.Strength];
            result.Stats[StatType.Stamina] = a.Stats[StatType.Stamina] + b.Stats[StatType.Stamina];

            return result;
        }

        public static bool operator ==(Entity a, Entity b)
        {
            return a.Name == b.Name && a.Stats == b.Stats;           
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }
    }
}
