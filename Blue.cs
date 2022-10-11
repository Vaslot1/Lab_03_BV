using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_BV
{
    internal class Blue
    {
        public int B;
        public Blue(int b)
        {
            B = b;
        }

        public RGB BtoRGB()
        {
            return new RGB(0, 0, B);
        }
    }
}
