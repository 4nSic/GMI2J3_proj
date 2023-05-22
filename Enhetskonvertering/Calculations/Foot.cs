
namespace Enhetskonvertering
{
    public class Foot
    {

        private const double CM = 0.032808;
        private const double METER = 3.2808;
        private const double INCH = 12;
        private const double YARD = 3;

        public  double ToCm(double foot)
        {
            return foot / CM;
        }

        public  double ToMeter(double foot)
        {
            return foot / METER;
        }

        public  double ToInch(double foot)
        {
            return foot * INCH;
        }

        public  double ToYard(double foot)
        {
            return foot / YARD;
        }

        //cm = length / 0.032808;
        //inch = length * 12;
        //meter = length / 3.2808;
        //yard = length / 3;

    }
}
