using System;

    namespace Enhetskonvertering
    {
        public class Volume
        {
            private const int AREA = 3;

            public  double Kub(double basen, double djup, double height)
            {
                return basen * djup * height;             
            }

            public  double Pyramid(double basen, double djup, double height)
            {
                return basen * djup * height / AREA;
            }

            public  double Sphere(double radius)
            {
                return Math.Pow(radius, AREA) * 4 * Math.PI / AREA;
            }   //math.pow betyder radius upphöjt i 3 
        }
    }

