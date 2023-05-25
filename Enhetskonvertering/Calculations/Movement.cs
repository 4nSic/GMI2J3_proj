
namespace Enhetskonvertering
{
    public class Movement
    {
        private const int MINUTS_IN_AN_HOUR = 60;

        public  double Speed(double distance, double time)
        {
            return distance / (time / MINUTS_IN_AN_HOUR);
        }

        public  double Time(double distance, double speed)
        {
            return (distance / speed) * MINUTS_IN_AN_HOUR;
        }

        public  double Distance(double speed, double time)
        {
            return speed * (time / MINUTS_IN_AN_HOUR);
        }
    }
}
