
namespace Enhetskonvertering
{
    public class Celsius
    {
        public  double ToFarenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }
        public  double ToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

    }
}
