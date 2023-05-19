using System;

    namespace Enhetskonvertering
    {
        internal struct Volume
        {
            private const int AREA = 3;

            public static double Kub(double basen, double djup, double height)
            {
                return basen * djup * height;             
            }

            public static double Pyramid(double basen, double djup, double height)
            {
                return basen * djup * height / AREA;
            }

            public static double Sphere(double radius)
            {
                return Math.Pow(radius, AREA) * 4 * Math.PI / AREA;
            }   //math.pow betyder radius upphöjt i 3 
        }
    }

