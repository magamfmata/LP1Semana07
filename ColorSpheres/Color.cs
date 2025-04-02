using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        private byte red;

        private byte green;

        private byte blue;

        private byte alpha;

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            _red = red;
            _green = green;
            _blue = blue;
            _alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
            _alpha = 255;
        }
    }
}