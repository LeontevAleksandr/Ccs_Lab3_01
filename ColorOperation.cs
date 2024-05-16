using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ccs_Lab3_01
{
    internal class HSVColor
    {
        public double Hue { get; set; } // от 0 до 360
        public double Saturation { get; set; } // от 0 до 1
        public double Value { get; set; } // от 0 до 1

        public HSVColor(double hue, double saturation, double value)
        {
            Hue = hue;
            Saturation = saturation;
            Value = value;
        }

        public RGBColor ToRGB()
        {
            double chroma = Value * Saturation;
            double hue60 = Hue / 60;
            double x = chroma * (1 - Math.Abs(hue60 % 2 - 1));
            double r1, g1, b1;

            if (hue60 >= 0 && hue60 < 1)
            {
                r1 = chroma;
                g1 = x;
                b1 = 0;
            }
            else if (hue60 >= 1 && hue60 < 2)
            {
                r1 = x;
                g1 = chroma;
                b1 = 0;
            }
            else if (hue60 >= 2 && hue60 < 3)
            {
                r1 = 0;
                g1 = chroma;
                b1 = x;
            }
            else if (hue60 >= 3 && hue60 < 4)
            {
                r1 = 0;
                g1 = x;
                b1 = chroma;
            }
            else if (hue60 >= 4 && hue60 < 5)
            {
                r1 = x;
                g1 = 0;
                b1 = chroma;
            }
            else
            {
                r1 = chroma;
                g1 = 0;
                b1 = x;
            }

            double m = Value - chroma;
            double r = r1 + m;
            double g = g1 + m;
            double b = b1 + m;

            return new RGBColor(r, g, b);
        }

        // Методы для операций над цветом
        public void AddRed(double amount)
        {
            Hue += amount;
        }

        public void SubtractRed(double amount)
        {
            Hue -= amount;
        }

        public void AddGreen(double amount)
        {
            Saturation += amount;
        }

        public void SubtractGreen(double amount)
        {
            Saturation -= amount;
        }

        public void AddBlue(double amount)
        {
            Value += amount;
        }

        public void SubtractBlue(double amount)
        {
            Value -= amount;
        }

        public void AddSaturation(double amount)
        {
            Saturation += amount;
        }

        public void SubtractSaturation(double amount)
        {
            Saturation -= amount;
        }

        public void AddBrightness(double amount)
        {
            Value += amount;
        }

        public void SubtractBrightness(double amount)
        {
            Value -= amount;
        }
    }

    public class RGBColor
    {
        public double Red { get; set; } // от 0 до 1
        public double Green { get; set; } // от 0 до 1
        public double Blue { get; set; } // от 0 до 1

        public RGBColor(double red, double green, double blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        internal object ToColor()
        {
            throw new NotImplementedException();
        }
    }
}
