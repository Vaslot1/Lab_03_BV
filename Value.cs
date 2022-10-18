using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_BV
{
    internal class Value
    {
        public int V;
        public Value(int v)
        {
            V = v;
        }

        public HSV BtoRGB()
        {
            return new HSV(0, 0, V);
        }
    }
}
