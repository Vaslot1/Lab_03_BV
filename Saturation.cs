using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_BV
{
    internal class Saturation
    {
        public int S;
        public Saturation(int s)
        {
            S = s;
        }

        public HSV StoHSV()
        {
            return new HSV(0, S, 0);
        }
    }
}
