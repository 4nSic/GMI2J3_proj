
namespace Enhetskonvertering
{
    public class Meter
    {
        public const int CM = 100;
        public const double INCH = 0.0254;
        public const double YARD = 1.0936133;
        public const double FOOT = 3.2808399;


        public double ToCm(double meter)
        {
            return meter * CM;
        }

        public double ToInch(double meter)
        {
            return meter / INCH;
        }

        public double ToYard(double meter)
        {
            return meter * YARD;
        }

        public double ToFoot(double meter)
        {
            return meter * FOOT;
        }

        //cm = length * 100;
        //inch = length / 0.0254;
        //yard = length * 1.0936133;
        //foot = length * 3.2808399;
    }
}
