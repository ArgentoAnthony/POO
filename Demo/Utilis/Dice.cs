using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Utilis
{
    public static class Dice
    {
        public static int Throw(int nbDice, int nbToKeep)
        {
            List<int> throws = new List<int>();
            Random r = new Random();
            for (int i = 0; i < nbDice; i++)
            {
                throws.Add(r.Next(6)+1);
            }
            //throws.Sort();
            //throws.Reverse();
            //int sum = 0;

            //for (int i = 0;i < nbToKeep;i++)
            //{
            //    sum += throws[i];
            //}

            //return sum;

            foreach (int nb in throws)
            {

            }

            return throws.OrderByDescending(nb => nb).Take(nbToKeep).Sum();
        }
    }
}
