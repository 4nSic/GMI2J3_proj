
namespace Enhetskonvertering
{
    internal static class Celsius
    {
        public static double ToFarenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }
        public static double ToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

    }
}
