using System;

namespace Enhetskonvertering
{
    public class konverter
    {
        private IDisplayHandler display;

        public konverter(IDisplayHandler displayHandler) 
        {
            display = displayHandler;
        }

        /*      Konvertering av Celsius Farenheit & Kelvin        */
        public void Kelvins(double temp)
        {
            display.ShowMessege($"{temp} Kelvin motsvarar\n{Kelvin.ToFarenheit(temp)} Farenheit\n{Kelvin.ToCelsius(temp)} Celsius.");
            Utilities.PauseText();
        }

        public void Farenheits(double temp)
        {
            display.ShowMessege($"{temp} Farenheit motsvarar\n{Farenheit.ToCelsius(temp)} Celsius\n{Farenheit.ToKelvin(temp)} Kelvin.");
            Utilities.PauseText();
        }

        public void Celsiuss(double temp)
        {
            display.ShowMessege($"{temp} Celsius motsvarar\n{Celsius.ToFarenheit(temp)} Farenheit\n{Celsius.ToKelvin(temp)} Kelvin.");
            Utilities.PauseText();
        }

        /*      Konvertering av Cm Meter Inch Yard Foot           */
        public void Centimeter(double length)
        {
            display.ShowMessege($"{length} cm motsvarar\n{Cm.ToMeter(length)} meter\n{Cm.ToInch(length)} inch\n{Cm.ToYard(length)} yard\n{Cm.ToFoot(length)} foot");
            Utilities.PauseText();
        }

        public void Meters(double length)
        {
            Console.WriteLine("{0:0.##} meter motsvarar\n{1:0.##} cm\n{2:0.##} inch\n{3:0.##} yard\n{4:0.##} foot", length, Meter.ToCm(length), 
                                                                                                                            Meter.ToInch(length), 
                                                                                                                            Meter.ToYard(length), 
                                                                                                                            Meter.ToFoot(length));
            Utilities.PauseText();
        }

        public void Inches(double length)
        {
            Console.WriteLine("{0:0.##} inches motsvarar\n{1:0.##} cm\n{2:0.##} meter\n{3:0.##} yard\n{4:0.##} foot", length, Inch.ToCm(length), 
                                                                                                                              Inch.ToMeter(length), 
                                                                                                                              Inch.ToYard(length), 
                                                                                                                              Inch.ToFoot(length));
            Utilities.PauseText();
        }

        public void Yards(double length)
        {
            Console.WriteLine("{0:0.##} yards motsvarar\n{1:0.##} cm\n{2:0.##} meter\n{3:0.##} inch\n{4:0.##} foot", length, Yard.ToCm(length), 
                                                                                                                             Yard.ToMeter(length), 
                                                                                                                             Yard.ToInch(length), 
                                                                                                                             Yard.ToFoot(length));
            Utilities.PauseText();
        }

        public void Foots(double length)
        {
            Console.WriteLine("{0:0.##} foot motsvarar\n{1:0.##} cm\n{2:0.##} meter\n{3:0.##} inch\n{4:0.##} yard", length, Foot.ToCm(length), 
                                                                                                                            Foot.ToMeter(length), 
                                                                                                                            Foot.ToInch(length), 
                                                                                                                            Foot.ToYard(length));
            Utilities.PauseText();
        }

        /*      Konvertering av hastigheter           */
        public void Speed(double distance, double time)
        {

            Console.WriteLine("Om du färdas {0:0.##}km på {1:0.##} minuter \nHar du hållit denna hastighet {2:0.##}km/h", distance, time, Movement.Speed(distance, time));
            Utilities.PauseText();
        }

        public void Time(double distance, double speed)
        {
            Console.WriteLine("Om du färdas {0:0.##}km och håller {1:0.##} km/h \nBlir resetiden {2:0.##} minuter", distance, speed, Movement.Time(distance, speed));
            Utilities.PauseText();
        }

        public void Distance(double speed, double time)
        {
            Console.WriteLine("Om du färdas i {0:0.##}km/h och resetiden blir {1:0.##} minuter \nBlir sträckan {2:0.##}km", speed, time, Movement.Distance(speed, time));
            Utilities.PauseText();
        }

        /*      Beräkning av area                     */
        public void Rektangel(double basen, double height)
        {
            
                Console.WriteLine("En Rektangel med basen {0:0.##}cm och höjden {1:0.##}cm \nhar arean {2:0.##}cm\u00b2", basen, height, Area.Rektangel(basen, height));
                Utilities.PauseText();
            
        }

        public void Triangel(double basen, double height)
        {
            
                Console.WriteLine("En Triangel med basen {0:0.##}cm och höjden {1:0.##}cm \nhar arean {2:0.##}cm\u00b2", basen, height, Area.Triangel(basen, height));
                Utilities.PauseText();
            
        }

        public void Cirkel(double radius)
        {
            
                Console.WriteLine("En Cirkel med radie {0:0.##}cm \nhar arean {1:0.##}cm\u00b2", radius, Area.Cirkel(radius));
                Utilities.PauseText();
           
        }

        /*      Beräkning av volym                     */
        public void Kub(double basen, double djup, double height)
        {
            Console.WriteLine("Ett rätblock med basen {0:0.##}cm och djupet {1:0.##}cm samt höjden {2:0.##}cm \nhar volymen {3:0.##}cm\u00b3", basen, djup, height, 
                                                                                                                              Volume.Kub(basen, djup, height));
            Utilities.PauseText();
        }

        public void Pyramid(double basen, double djup, double height)
        {
            Console.WriteLine("En Pyramid med basen {0:0.##}cm och djupet {1:0.##}cm samt höjden {2:0.##}cm \nhar volymen {3:0.##}cm\u00b3", basen, djup, height,
                                                                                                                              Volume.Pyramid(basen, djup, height));
            Utilities.PauseText();
        }

        public void Sphere(double radius)
        {
            Console.WriteLine("En Sphere med radie {0:0.##}cm \nhar volymen {1:0.##}cm\u00b3", radius, Volume.Sphere(radius));
            Utilities.PauseText();
        }

        /*      Beräkning av ohms law                    */
        public void Voltage(double current, double resistance)
        {        
            Console.WriteLine("En ström på {0:0.##} amp över ett motstånd på {1:0.##} \u2126 \nger en spänning på {2:0.##} volt", current, resistance, Ohmslaw.Voltage(current, resistance));
            Utilities.PauseText();
        }

        public void Current(double voltage, double resistance)
        {
            Console.WriteLine("En spänning på {0:0.##} volt över ett motstånd på {1:0.##} \u2126 \nger en ström på {2:0.##} amp", voltage, resistance, Ohmslaw.Current(voltage, resistance));
            Utilities.PauseText();
        }

        public void Resistance(double voltage, double current)
        {
            Console.WriteLine("En spänning på {0:0.##} volt med en ström på {1:0.##}amp \nger ett motstånd på {2:0.##} \u2126", voltage, current, Ohmslaw.Resistance(voltage, current));
            Utilities.PauseText();
        }
    }
}