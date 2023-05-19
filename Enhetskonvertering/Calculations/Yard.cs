
namespace Enhetskonvertering
{
    internal struct Yard
    {

        private const double CM = 91.44;
        private const double METER = 0.9144;
        private const double INCH = 36;
        private const double FOOT = 3;

        public static double ToCm(double yard)
        {
            return yard * CM;
        }

        public static double ToMeter(double yard)
        {
            return yard * METER;
        }

        public static double ToInch(double yard)
        {
            return yard * INCH;
        }

        public static double ToFoot(double yard)
        {
            return yard * FOOT;
        }      
    }
}
