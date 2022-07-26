using System;


namespace Matt_Manleys_Plumbing_Extravaganza.Game.Casting
{

    /// <summary>
    /// A color.
    /// </summary>
    public class Color
    {

        public static Color White() { return new Color(255, 255, 255); }
        public static Color Transparent() { return new Color(0, 0, 0, 0); }


        private byte _red = 0;
        private byte _green = 0;
        private byte _blue = 0;
        private byte _alpha = 0;


        public Color(byte red, byte green, byte blue, byte alpha = 255)
        {
            _red = red;
            _green = green;
            _blue = blue;
            _alpha = alpha;
        }


        public Tuple<byte, byte, byte, byte> ToTuple()
        {
            return Tuple.Create(_red, _green, _blue, _alpha);
        }
        
    }
}