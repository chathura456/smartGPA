﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGPA
{

    //090a38 9,10,56
    //02002f 2,0,47

    //262b48 38,43,72
    //1d1f38 29,31,56

    //current
    //39,39,58
    //51,51,76


    public static class ThemeColor
    {
       public static List<string> ColorList = new List<string>() {
        "#800080",
        "#FFA500",
        "#008000",
        "#0000FF",
        "#08A04B",
        "#C147E9",
        "#C060A1",
        "#E94560",
        "#FF1E56",
        "#FF0000",
        "#A7D129",
        "#9153F4",
        "#FFD717",
        "#FD2E2E",
        "#106EE8",
        "#5902EC",
        "#033FFF"
        };

        public static Color DarkGrey= Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
        public static Color LightGrey = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            //If correction factor less than 0, darken color
            if(correctionFactor<0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red =(255-red) * correctionFactor + red;
                green = (255 -green) * correctionFactor + green;
                blue = (255 -blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A,(byte)red,(byte)green, (byte)blue);
        }
    }
}
