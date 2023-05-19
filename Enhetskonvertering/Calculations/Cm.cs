
namespace Enhetskonvertering
{
    internal struct Cm
    {
        private const int METER =100;
        private const double INCH = 2.54;
        private const double YARD = 0.010936133;
        private const double FOOT = 0.032808399;

        public static double ToMeter(double cm)
        {
            return cm / METER;
        }

        public static double ToInch(double cm)
        {
            return cm / INCH;
        }

        public static double ToYard(double cm)
        {
            return cm * YARD;
        }

        public static double ToFoot(double cm)
        {
            return cm * FOOT;
        }

        //meter = length / 100;
        //inch = length / 2.54;
        //yard = length * 0.010936133;
        //foot = length * 0.032808399;
    }
}
