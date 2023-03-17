using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGPA
{
    
    public static class ThemeColor
    {
       public static List<string> ColorList = new List<string>() {
        "#800080",
        "#FFA500",
        "#008000",
        "#0000FF",
        "#08A04B"
        };

        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
    }
}
