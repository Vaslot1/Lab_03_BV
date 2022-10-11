using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_BV
{
    internal class HSV
    {
        public int H;
        public int S;
        public int V;
        public HSV(int h, int s, int v)
        {
            H = h;
            S = s;
            V = v;
        }
        public RGB HSVToRGB()
        {
            float V_min,V_dec,V_inc,a,s=S,v=V;
            int r = 0, g = 0, b = 0;
            V_min = ((100 - s) * v) / 100f;
            a = (v - V_min) * ((H % 60) / 60f);
            V_inc = V_min + a;
            V_dec = v - a;
            switch ((int)(H / 60) % 6)
            {
                case 0:
                    r = (int)((v / 100) * 255);
                    g = (int)((V_inc/100) * 255);
                    b = (int)((V_min / 100) * 255);
                    break;   
                case 1:      
                    r = (int)((V_dec/100) * 255);
                    g = (int)((v / 100) * 255);
                    b = (int)((V_min / 100) * 255);
                    break;          
                case 2:                
                    r = (int)((V_min / 100) * 255);
                    g = (int)((v / 100) * 255);
                    b = (int)((V_inc / 100) * 255);
                    break;          
                case 3:                
                    r = (int)((V_min/100) * 255);
                    g = (int)((V_dec / 100) * 255);
                    b = (int)((v / 100) * 255);
                    break;          
                case 4:               
                    r = (int)((V_inc / 100) * 255);
                    g = (int)((V_min / 100) * 255);
                    b = (int)((v / 100) * 255);
                    break;         
                case 5:              
                    r = (int)((v / 100) * 255);
                    g = (int)((V_min / 100) * 255);
                    b = (int)((V_dec / 100) * 255);
                    break;
            }
            RGB new_RGB = new RGB(r,g,b);

            return new_RGB;
        }
        public static HSV operator+(HSV hsv,Red r)
        {
            RGB newRGB = hsv.HSVToRGB();
            return (newRGB + r.RtoRGB()).RGBToHSV();
        }
        public static HSV operator +(HSV hsv, Green g)
        {
            RGB newRGB = hsv.HSVToRGB();
            return (newRGB + g.GtoRGB()).RGBToHSV();
        }
        public static HSV operator +(HSV hsv, Blue b)
        {
            RGB newRGB = hsv.HSVToRGB();
            return (newRGB + b.BtoRGB()).RGBToHSV();
        }
        public static HSV operator -(HSV hsv, Red r)
        {
            RGB newRGB = hsv.HSVToRGB();
            return (newRGB - r.RtoRGB()).RGBToHSV();
        }
        public static HSV operator -(HSV hsv, Green g)
        {
            RGB newRGB = hsv.HSVToRGB();
            return (newRGB - g.GtoRGB()).RGBToHSV();
        }
        public static HSV operator -(HSV hsv, Blue b)
        {
            RGB newRGB = hsv.HSVToRGB();
            return (newRGB - b.BtoRGB()).RGBToHSV();
        }
        public static HSV operator +(HSV hsv, Saturation s)
        {
            return new HSV (hsv.H,hsv.S+s.S,hsv.V);
        }
        public static HSV operator -(HSV hsv, Saturation s)
        {
            return new HSV(hsv.H, hsv.S - s.S, hsv.V);
        }
        public static HSV operator +(HSV hsv, Value v)
        {
            return new HSV(hsv.H, hsv.S, hsv.V+ v.V);
        }
        public static HSV operator -(HSV hsv, Value v)
        {
            return new HSV(hsv.H, hsv.S, hsv.V - v.V);
        }
        public  void CheckHSV()
        {
            if(this.H>360|| this.H < 0)
            {
                throw new Exception();
            }
            if (this.S > 100 || this.S < 0)
            {
                throw new Exception();
            }
            if (this.V > 100 || this.V < 0)
            {
                throw new Exception();
            }
        }
    }
}
