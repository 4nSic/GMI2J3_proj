using System;

namespace Enhetskonvertering
{
    public static class Konverter
    {

        /*      Konvertering av Celsius Farenheit & Kelvin        */
        public static void Kelvins(double temp)
        {
            Console.WriteLine("{0:#.##} Kelvin motsvarar\n{1:#.##} Farenheit\n{2:#.##} Celsius.", temp, Kelvin.ToFarenheit(temp), 
                                                                                                        Kelvin.ToCelsius(temp));
            Utilities.PauseText();           
        }

        public static void Farenheits(double temp)
        {
            Console.WriteLine("{0:#.##} Farenheit motsvarar\n{1:#.##} Celsius\n{2:#.##} Kelvin.", temp, Farenheit.ToCelsius(temp), 
                                                                                                        Farenheit.ToKelvin(temp));
            Utilities.PauseText();
        }

        public static void Celsiuss(double temp)
        {
            Console.WriteLine("{0:#.##} Celsius motsvarar\n{1:#.##} Farenheit\n{2:#.##} Kelvin.", temp, Celsius.ToFarenheit(temp), 
                                                                                                        Celsius.ToKelvin(temp));
            Utilities.PauseText();
        }

        /*      Konvertering av Cm Meter Inch Yard Foot           */
        internal static void Centimeter(double length)
        {
            Console.WriteLine("{0:0.##} cm motsvarar\n{1:0.##} meter\n{2:0.##} inch\n{3:0.##} yard\n{4:0.##} foot", length, Cm.ToMeter(length), 
                                                                                                                            Cm.ToInch(length), 
                                                                                                                            Cm.ToYard(length), 
                                                                                                                            Cm.ToFoot(length));
            Utilities.PauseText();
        }

        internal static void Meters(double length)
        {
            Console.WriteLine("{0:0.##} meter motsvarar\n{1:0.##} cm\n{2:0.##} inch\n{3:0.##} yard\n{4:0.##} foot", length, Meter.ToCm(length), 
                                                                                                                            Meter.ToInch(length), 
                                                                                                                            Meter.ToYard(length), 
                                                                                                                            Meter.ToFoot(length));
            Utilities.PauseText();
        }

        internal static void Inches(double length)
        {
            Console.WriteLine("{0:0.##} inches motsvarar\n{1:0.##} cm\n{2:0.##} meter\n{3:0.##} yard\n{4:0.##} foot", length, Inch.ToCm(length), 
                                                                                                                              Inch.ToMeter(length), 
                                                                                                                              Inch.ToYard(length), 
                                                                                                                              Inch.ToFoot(length));
            Utilities.PauseText();
        }

        internal static void Yards(double length)
        {
            Console.WriteLine("{0:0.##} yards motsvarar\n{1:0.##} cm\n{2:0.##} meter\n{3:0.##} inch\n{4:0.##} foot", length, Yard.ToCm(length), 
                                                                                                                             Yard.ToMeter(length), 
                                                                                                                             Yard.ToInch(length), 
                                                                                                                             Yard.ToFoot(length));
            Utilities.PauseText();
        }

        internal static void Foots(double length)
        {
            Console.WriteLine("{0:0.##} foot motsvarar\n{1:0.##} cm\n{2:0.##} meter\n{3:0.##} inch\n{4:0.##} yard", length, Foot.ToCm(length), 
                                                                                                                            Foot.ToMeter(length), 
                                                                                                                            Foot.ToInch(length), 
                                                                                                                            Foot.ToYard(length));
            Utilities.PauseText();
        }

        /*      Konvertering av hastigheter           */
        internal static void Speed(double distance, double time)
        {

            Console.WriteLine("Om du färdas {0:0.##}km på {1:0.##} minuter \nHar du hållit denna hastighet {2:0.##}km/h", distance, time, Movement.Speed(distance, time));
            Utilities.PauseText();
        }

        internal static void Time(double distance, double speed)
        {
            Console.WriteLine("Om du färdas {0:0.##}km och håller {1:0.##} km/h \nBlir resetiden {2:0.##} minuter", distance, speed, Movement.Time(distance, speed));
            Utilities.PauseText();
        }

        internal static void Distance(double speed, double time)
        {
            Console.WriteLine("Om du färdas i {0:0.##}km/h och resetiden blir {1:0.##} minuter \nBlir sträckan {2:0.##}km", speed, time, Movement.Distance(speed, time));
            Utilities.PauseText();
        }

        /*      Beräkning av area                     */
        internal static void Rektangel(double basen, double height)
        {
            
                Console.WriteLine("En Rektangel med basen {0:0.##}cm och höjden {1:0.##}cm \nhar arean {2:0.##}cm\u00b2", basen, height, Area.Rektangel(basen, height));
                Utilities.PauseText();
            
        }

        internal static void Triangel(double basen, double height)
        {
            
                Console.WriteLine("En Triangel med basen {0:0.##}cm och höjden {1:0.##}cm \nhar arean {2:0.##}cm\u00b2", basen, height, Area.Triangel(basen, height));
                Utilities.PauseText();
            
        }

        internal static void Cirkel(double radius)
        {
            
                Console.WriteLine("En Cirkel med radie {0:0.##}cm \nhar arean {1:0.##}cm\u00b2", radius, Area.Distance(radius));
                Utilities.PauseText();
           
        }

        /*      Beräkning av volym                     */
        internal static void Kub(double basen, double djup, double height)
        {
            Console.WriteLine("Ett rätblock med basen {0:0.##}cm och djupet {1:0.##}cm samt höjden {2:0.##}cm \nhar volymen {3:0.##}cm\u00b3", basen, djup, height, 
                                                                                                                              Volume.Kub(basen, djup, height));
            Utilities.PauseText();
        }
        
        internal static void Pyramid(double basen, double djup, double height)
        {
            Console.WriteLine("En Pyramid med basen {0:0.##}cm och djupet {1:0.##}cm samt höjden {2:0.##}cm \nhar volymen {3:0.##}cm\u00b3", basen, djup, height,
                                                                                                                              Volume.Pyramid(basen, djup, height));
            Utilities.PauseText();
        }

        internal static void Sphere(double radius)
        {
            Console.WriteLine("En Sphere med radie {0:0.##}cm \nhar volymen {1:0.##}cm\u00b3", radius, Volume.Sphere(radius));
            Utilities.PauseText();
        }

        /*      Beräkning av ohms law                    */
        internal static void Voltage(double current, double resistance)
        {        
            Console.WriteLine("En ström på {0:0.##} amp över ett motstånd på {1:0.##} \u2126 \nger en spänning på {2:0.##} volt", current, resistance, Ohmslaw.Voltage(current, resistance));
            Utilities.PauseText();
        }

        internal static void Current(double voltage, double resistance)
        {
            Console.WriteLine("En spänning på {0:0.##} volt över ett motstånd på {1:0.##} \u2126 \nger en ström på {2:0.##} amp", voltage, resistance, Ohmslaw.Current(voltage, resistance));
            Utilities.PauseText();
        }

        internal static void Resistance(double voltage, double current)
        {
            Console.WriteLine("En spänning på {0:0.##} volt med en ström på {1:0.##}amp \nger ett motstånd på {2:0.##} \u2126", voltage, current, Ohmslaw.Resistance(voltage, current));
            Utilities.PauseText();
        }
    }
}