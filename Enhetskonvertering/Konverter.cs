using System;

namespace Enhetskonvertering
{
    public class Konverter
    {
        private IDisplayHandler display;

        private IInputHandler inputHandler;
        
        private Area area;
        private Celsius celsius;
        private Cm cm;
        private Farenheit farenheit;
        private Foot foot;
        private Inch inch;
        private Kelvin kelvin;
        private Meter meter;
        private Movement movement;
        private Ohmslaw ohmslaw;
        private Volume volume;
        private Yard yard;

        public Konverter(IDisplayHandler displayHandler, IInputHandler inputHandler) 
        {
            display = displayHandler;

            this.inputHandler = inputHandler;

            area = new Area();  
            celsius = new Celsius();
            cm = new Cm();
            farenheit = new Farenheit();
            foot = new Foot();
            inch = new Inch(); 
            kelvin = new Kelvin();
            meter = new Meter();
            movement = new Movement();
            ohmslaw = new Ohmslaw();   
            volume = new Volume();
            yard = new Yard();
        }

        /*      Konvertering av Celsius Farenheit & Kelvin        */
        public void Kelvins(double temp)
        {
            display.ShowMessege($"{temp} Kelvin motsvarar\n" +
                                                  $"{kelvin.ToFarenheit(temp):0.##} Farenheit\n" +
                                                  $"{kelvin.ToCelsius(temp):0.##} Celsius.");
            display.ShowMessege(Meny.PAUSE_TEXT);
            inputHandler.AwaitInput();
        }

        public void Farenheits(double temp)
        {
            display.ShowMessege($"{temp} Farenheit motsvarar\n" +
                                                   $"{farenheit.ToCelsius(temp):0.##} Celsius\n" +
                                                   $"{farenheit.ToKelvin(temp):0.##} Kelvin.");
            display.ShowMessege(Meny.PAUSE_TEXT);
            inputHandler.AwaitInput();
        }

        public void Celsiuss(double temp)
        {
            display.ShowMessege($"{temp} Celsius motsvarar\n" +
                                                   $"{celsius.ToFarenheit(temp):0.##} Farenheit\n" +
                                                   $"{celsius.ToKelvin(temp):0.##} Kelvin.");
            display.ShowMessege(Meny.PAUSE_TEXT);
            inputHandler.AwaitInput();
        }

        /*      Konvertering av Cm Meter Inch Yard Foot           */
        public void Centimeter(double length)
        {
            display.ShowMessege($"{length} cm motsvarar\n" +
                                                   $"{cm.ToMeter(length):0.##} meter\n" +
                                                   $"{cm.ToInch(length):0.##} inch\n" +
                                                   $"{cm.ToYard(length):0.##} yard\n" +
                                                   $"{cm.ToFoot(length):0.##} foot");
            display.ShowMessege(Meny.PAUSE_TEXT);
            inputHandler.AwaitInput();
        }

        public void Meters(double length)
        {
            display.ShowMessege($"{length} meter motsvarar\n{meter.ToCm(length):0.##} " +
                                                    $"cm\n{meter.ToInch(length):0.##} " +
                                                    $"inch\n{meter.ToYard(length):0.##} " +
                                                    $"yard\n{meter.ToFoot(length):0.##} " +
                                                    $"foot");
            display.ShowMessege(Meny.PAUSE_TEXT);
            inputHandler.AwaitInput();
        }

        public void Inches(double length)
        {
            display.ShowMessege($"{length} inches motsvarar\n" +
                                                   $"{inch.ToCm(length):0.##} cm\n" +
                                                   $"{inch.ToMeter(length):0.##} meter\n" +
                                                   $"{inch.ToYard(length):0.##} yard\n" +
                                                   $"{inch.ToFoot(length):0.##} foot");
            display.ShowMessege(Meny.PAUSE_TEXT);
            inputHandler.AwaitInput();
        }

        public void Yards(double length)
        {
            display.ShowMessege($"{length} yards motsvarar\n" +
                                                   $"{yard.ToCm(length):0.##} cm\n" +
                                                   $"{yard.ToMeter(length):0.##} meter\n" +
                                                   $"{yard.ToInch(length):0.##} inch\n" +
                                                   $"{yard.ToFoot(length):0.##} foot");
            display.ShowMessege(Meny.PAUSE_TEXT);
            inputHandler.AwaitInput();
        }

        public void Foots(double length)
        {
            display.ShowMessege($"{length} foot motsvarar\n" +
                                                   $"{foot.ToCm(length):0.##} cm\n" +
                                                   $"{foot.ToMeter(length):0.##} meter\n" +
                                                   $"{foot.ToInch(length):0.##} inch\n" +
                                                   $"{foot.ToYard(length):0.##} yard");
            display.ShowMessege(Meny.PAUSE_TEXT);
            inputHandler.AwaitInput();
        }

        /*      Konvertering av hastigheter           */
        public void Speed(double distance, double time)
        {

            display.ShowMessege($"Om du färdas {distance}km på {time} minuter \n" +
                              $"Har du hållit denna hastighet {movement.Speed(distance, time):0.##}km/h");
            display.ShowMessege(Meny.PAUSE_TEXT);
            inputHandler.AwaitInput();
        }

        public void Time(double distance, double speed)
        {
            display.ShowMessege($"Om du färdas {distance}km och håller {speed} km/h \n" +
                              $"Blir resetiden {movement.Time(distance, speed):0.##} minuter");
            display.ShowMessege(Meny.PAUSE_TEXT);
            inputHandler.AwaitInput();
        }

        public void Distance(double speed, double time)
        {
            display.ShowMessege($"Om du färdas i {speed}km/h och resetiden blir {time} minuter \n" +
                              $"Blir sträckan {movement.Distance(speed, time):0.##}km");
            display.ShowMessege(Meny.PAUSE_TEXT);
            inputHandler.AwaitInput();
        }

        /*      Beräkning av area                     */
        public void Rektangel(double basen, double height)
        {
            
                display.ShowMessege($"En Rektangel med basen {basen}cm och höjden {height}cm \n" +
                                  $"har arean {area.Rektangel(basen, height):0.##}cm\u00b2");
                display.ShowMessege(Meny.PAUSE_TEXT);
                inputHandler.AwaitInput();

        }

        public void Triangel(double basen, double height)
        {
            
                display.ShowMessege($"En Triangel med basen {basen}cm och höjden {height}cm \n" +
                                  $"har arean {area.Triangel(basen, height):0.##}cm\u00b2");
                display.ShowMessege(Meny.PAUSE_TEXT);
                inputHandler.AwaitInput();

        }

        public void Cirkel(double radius)
        {
            
                display.ShowMessege($"En Cirkel med radie {radius:0.##}cm \n" +
                                  $"har arean {area.Cirkel(radius):0.##}cm\u00b2");
                display.ShowMessege(Meny.PAUSE_TEXT);
                inputHandler.AwaitInput();
           
        }

        /*      Beräkning av volym                     */
        public void Kub(double basen, double djup, double height)
        {
            display.ShowMessege($"Ett rätblock med basen {basen:0.##}cm " +
                              $"och djupet {djup:0.##}cm " +
                              $"samt höjden {height:0.##}cm \n" +
                              $"har volymen {volume.Kub(basen, djup, height):0.##}cm\u00b3");
            display.ShowMessege(Meny.PAUSE_TEXT);
            inputHandler.AwaitInput();
        }

        public void Pyramid(double basen, double djup, double height)
        {
            display.ShowMessege($"En Pyramid med basen {basen:0.##}cm " +
                              $"och djupet {djup:0.##}cm " +
                              $"samt höjden {height:0.##}cm \n" +
                              $"har volymen {volume.Pyramid(basen, djup, height):0.##}cm\u00b3");
            display.ShowMessege(Meny.PAUSE_TEXT);
            inputHandler.AwaitInput();
        }

        public void Sphere(double radius)
        {
            display.ShowMessege($"En Sphere med radie {radius:0.##}cm \n" +
                              $"har volymen {volume.Sphere(radius):0.##}cm\u00b3");
            display.ShowMessege(Meny.PAUSE_TEXT);
            inputHandler.AwaitInput();
        }

        /*      Beräkning av ohms law                    */
        public void Voltage(double current, double resistance)
        {        
            display.ShowMessege($"En ström på {current:0.##} amp " +
                              $"över ett motstånd på {resistance:0.##} \u2126 \n" +
                              $"ger en spänning på {ohmslaw.Voltage(current, resistance):0.##} volt");
            display.ShowMessege(Meny.PAUSE_TEXT);
            inputHandler.AwaitInput();
        }

        public void Current(double voltage, double resistance)
        {
            display.ShowMessege($"En spänning på {voltage:0.##} volt " +
                              $"över ett motstånd på {resistance:0.##} \u2126 \n" +
                              $"ger en ström på {ohmslaw.Current(voltage, resistance):0.##} amp");
            display.ShowMessege(Meny.PAUSE_TEXT);
            inputHandler.AwaitInput();
        }

        public void Resistance(double voltage, double current)
        {
            display.ShowMessege($"En spänning på {voltage:0.##} volt" +
                              $" med en ström på {current:0.##}amp \n" +
                              $"ger ett motstånd på {ohmslaw.Resistance(voltage, current):0.##} \u2126");
            display.ShowMessege(Meny.PAUSE_TEXT);
            inputHandler.AwaitInput();
        }
    }
}