
namespace Enhetskonvertering
{
    internal struct Ohmslaw
    {

        public static double Voltage(double current, double resistance)
        {
            return current * resistance;
        }

        public static double Current(double voltage, double resistance)
        {
            return voltage / resistance;       
        }

        public static double Resistance(double voltage, double current)
        {
            return voltage / current;
        }
    }
}

