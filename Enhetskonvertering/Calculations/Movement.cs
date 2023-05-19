
namespace Enhetskonvertering
{
    internal struct Movement
    {
        private const int MINUTS_IN_AN_HOUR = 60;

        public static double Speed(double distance, double time)
        {
            return distance / (time / MINUTS_IN_AN_HOUR);
        }

        public static double Time(double distance, double speed)
        {
            return (distance / speed) * MINUTS_IN_AN_HOUR;
        }

        public static double Distance(double speed, double time)
        {
            return speed * (time / MINUTS_IN_AN_HOUR);
        }
    }
}
