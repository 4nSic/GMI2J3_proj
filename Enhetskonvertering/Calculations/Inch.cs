
namespace Enhetskonvertering
{
    internal struct Inch
    {
        private const double CM = 2.54;
        private const double METER = 0.0254;
        private const double YARD = 36;
        private const double FOOT = 12;

        public static double ToCm(double inch)
        {
            return inch * CM;
        }

        public static double ToMeter(double inch)
        {
            return inch * METER;
        }

        public static double ToYard(double inch)
        {
            return inch / YARD;
        }

        public static double ToFoot(double inch)
        {
            return inch / FOOT;
        }

        //cm = length * 2.54;
        //meter = length * 0.0254;
        //yard = length / 36;
        //foot = length / 12;
    }
}
