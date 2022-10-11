using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_BV
{
    internal class Red
    {
        public int R;
        public Red(int r)
        {
            R = r;
        }

        public RGB RtoRGB()
        {
            return new RGB(R, 0, 0);
        }
    }
}
