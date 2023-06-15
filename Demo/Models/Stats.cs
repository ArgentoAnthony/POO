using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public enum StatType
    {
        Hp,
        Strength,
        Stamina,
        Speed
    }
    public class Stats
    {
        private Dictionary<StatType, int> Stat = new Dictionary<StatType, int>();

        public int this[StatType stat]
        {
            get
            {
                if (!Stat.ContainsKey(stat))
                {
                    Stat.Add(stat, 0);
                }
                return Stat[stat];
            }
            set
            {
                if (!Stat.ContainsKey(stat))
                {
                    Stat.Add(stat, 0);
                }
                Stat[stat] = value;
            }
        }

        public void Append(StatType stat, int amount)
        {
            this[stat] += amount;
        }

        public static bool operator ==(Stats a, Stats b) 
        {
            bool isEqual = true;
            foreach (StatType stat in Enum.GetValues<StatType>())
            {
                if (a[stat] != b[stat])
                {
                    isEqual = false;
                }
            }
            return isEqual;
        }

        public static bool operator !=(Stats a, Stats b)
        {
            return !(a == b);
        }


    }
}
