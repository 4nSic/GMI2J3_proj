using System;

namespace Enhetskonvertering
{
    public class Area
    {
        private const int AREA = 2;

        public  double Rektangel(double basen, double height)
        {
            return  basen * height;
        }

        public  double Triangel(double basen, double height)
        {
            return basen * height / AREA;
        }

        public  double Cirkel(double radius)
        {
            return Math.Pow(radius, AREA) * Math.PI;
        }    
    }
}

