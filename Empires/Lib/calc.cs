using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empires.Lib
{
    public class Calc
    {
        public static Random rand = new Random();

        public static Double genMod()
        {
            Double temp = rand.NextDouble();
            if (temp > 0.5)
            {
                temp--;
            }
            temp *= 2;
            return temp;
        }
    }
}
