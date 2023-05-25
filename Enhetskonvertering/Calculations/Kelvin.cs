
namespace Enhetskonvertering
{
    public class Kelvin
    {
        public  double ToCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }
        public  double ToFarenheit(double kelvin)
        {
            return kelvin * 9 / 5 - 459.67;
        }
    }
}