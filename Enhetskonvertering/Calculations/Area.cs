using System;

namespace Enhetskonvertering
{
    internal struct Area
    {
        private const int AREA = 2;

        public static double Rektangel(double basen, double height)
        {
            return  basen * height;
        }

        public static double Triangel(double basen, double height)
        {
            return basen * height / AREA;
        }

        public static double Distance(double radius)
        {
            return Math.Pow(radius, AREA) * Math.PI;
        }    
    }
}

