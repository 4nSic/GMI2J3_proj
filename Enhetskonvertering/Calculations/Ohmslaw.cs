
namespace Enhetskonvertering
{
    public class Ohmslaw
    {

        public  double Voltage(double current, double resistance)
        {
            return current * resistance;
        }

        public  double Current(double voltage, double resistance)
        {
            return voltage / resistance;       
        }

        public  double Resistance(double voltage, double current)
        {
            return voltage / current;
        }
    }
}

