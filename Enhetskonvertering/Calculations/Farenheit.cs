
namespace Enhetskonvertering
{
    public class Farenheit
    {
        public  double ToCelsius(double farenheit)
        {
            return (farenheit - 32) * 5 / 9;
        }
        public  double ToKelvin(double farenheit)
        {
            return (farenheit + 459.67) * 5 / 9;
        }
    }
}
