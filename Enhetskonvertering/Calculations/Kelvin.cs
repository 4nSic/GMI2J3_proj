
namespace Enhetskonvertering
{
    internal static class Kelvin
    {
        public static double ToCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }
        public static double ToFarenheit(double kelvin)
        {
            return kelvin * 9 / 5 - 459.67;
        }
    }
}