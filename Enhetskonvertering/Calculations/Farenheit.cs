
namespace Enhetskonvertering
{
    internal static class Farenheit
    {
        public static double ToCelsius(double farenheit)
        {
            return (farenheit - 32) * 5 / 9;
        }
        public static double ToKelvin(double farenheit)
        {
            return (farenheit + 459.67) * 5 / 9;
        }
    }
}
