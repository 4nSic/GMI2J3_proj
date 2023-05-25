
namespace Enhetskonvertering
{
    public class Yard
    {

        private const double CM = 91.44;
        private const double METER = 0.9144;
        private const double INCH = 36;
        private const double FOOT = 3;

        public  double ToCm(double yard)
        {
            return yard * CM;
        }

        public  double ToMeter(double yard)
        {
            return yard * METER;
        }

        public  double ToInch(double yard)
        {
            return yard * INCH;
        }

        public  double ToFoot(double yard)
        {
            return yard * FOOT;
        }      
    }
}
