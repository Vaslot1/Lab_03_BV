using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_BV
{
    internal class RGB
    {
        public int R;
        public int G;
        public int B;
        public RGB(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }   
        public HSV RGBToHSV()
        {
            float  Max, Min,r=(R/255f),g=(G/255f),b=(B/255f),temp;
            int h = -1, s = 0, v = 0;
            float[] rgb = new float[3];
            rgb[0] = r;
            rgb[1] = g;
            rgb[2] = b;
            for(int i = 0; i < 2; i++)
            {
                for( int j = i+1; j < 3; j++) { 
                if (rgb[i] > rgb[j])
                {
                    temp = rgb[i];
                    rgb[i] = rgb[j];
                    rgb[j] = temp; 
                }
                }
            }
            Max = rgb[2];
            Min = rgb[0];
            if(Max == r && g >= b)
            {
                h = (int)((60 * ((g - b) / (Max - Min))));
            }
            if (Max == r && g < b)
            {
                h = (int)(60 * ((g - b) / (Max - Min))+360);
            }
            if (Max == g)
            {
                h = (int)(60 * ((b - r) / (Max - Min))+120);
            }
            if (Max == b )
            {
                h = (int)(60 * ((r - g) / (Max - Min))+240);
            }
            if (Max == 0)
            {
                s = 0;
            }
            else
            {
                s = (int)((1 - (Min / Max))*100);
            }
            v = (int)(Max * 100);
            HSV new_HSV = new HSV(h, s, v);
            return new_HSV;
        }
        public static RGB operator+(RGB rgb, RGB rgb1)
        {
            return new RGB(rgb.R + rgb1.R, rgb.G + rgb1.G, rgb.B + rgb1.B);
        }
        public static RGB operator-(RGB rgb, RGB rgb1)
        {
            return new RGB(rgb.R - rgb1.R, rgb.G - rgb1.G, rgb.B - rgb1.B);
        }
        public void CheckRGB()
        {
            if (this.R>255 || this.R < 0)
            {
                throw new Exception();
            }
            if (this.G > 255 || this.G < 0)
            {
                throw new Exception();
            }
            if (this.B > 255 || this.B < 0)
            {
                throw new Exception();
            }
        }
    }
}
