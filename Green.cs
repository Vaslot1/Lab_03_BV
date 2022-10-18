using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_BV
{
    internal class Green
    {
        public int G;
        public Green(int g)
        {
            G = g;
        }

        public RGB GtoRGB()
        {
            return new RGB(0, G, 0);
        }
    }
}
