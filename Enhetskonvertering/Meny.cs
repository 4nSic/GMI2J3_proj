using System;

namespace Enhetskonvertering
{
    public class Meny
    {
        public const string INPUTERROR = "Du har matat in ett felaktigt värde";
        public const string WRONG_INPUT = INPUTERROR + ", välj en siffra i menyn";
        public const string PAUSE_TEXT = "\nTryck på valfri tangent för att komma tillbaka till Menyn.";

        private static int result;
        protected IDisplayHandler display;
        private IInputHandler input;
        private Konverter konvert;

        public Meny(IDisplayHandler displayHandler, IInputHandler inputHandler, Konverter konverter)
        {
            display = displayHandler;
            input = inputHandler;
            konvert = konverter;
        }

        protected static string ErrorMess(string typ, string unit)
        {
            return INPUTERROR + $", ang en giltlig {unit} i {typ}.";
        }

        public enum MainMenyChoices
        {

            temp = 1,
            length = 2,
            speed = 3,
            area = 4,
            volym = 5,
            ohm = 6,
            exit = 7
        }

        public enum TempMenyChoices
        {
           celsius =1,
           farenheit=2,
           kelvin=3, 
           exit=4 
        }

        public enum LengthMenyChoices
        {
            cm=1,
            m=2,
            inch=3,
            yard=4,
            foot=5,
            exit=6
        }

        public enum AreaAndVolymMenyChoices
        { 
            rektangel=1,
            triangel=2,
            cirkel=3,
            exit=4
        }

        public enum OhmMenyChoices
        {
            voltage=1,
            current=2,
            resistance=3,
            exit=4
        }

        public enum SpeedMenyChoices
        {
            speed=1,
            time=2,
            distance=3,
            exit=4
        }

        public class ConsolInputHandler : IInputHandler
        {
            private IDisplayHandler display;

            public void AwaitInput() 
            {
                Console.ReadKey();
            }

            public ConsolInputHandler(IDisplayHandler displayHandler)
            {
                display = displayHandler;
            }

            public bool ReadInput(out int result)
            {
                display.ShowMessege("\nAnge ditt val: ");

                bool succes = int.TryParse(Console.ReadLine(), out result);

                if (!succes)
                {
                    display.ShowMessege(WRONG_INPUT);

                }

                return succes;
            }

            public bool ReadInput(Meny.TempMenyChoices tempTyp, out double result)
            {
                bool succes = double.TryParse(Console.ReadLine(), out result);

                if (succes)
                {
                    switch (tempTyp)
                    {
                        case Meny.TempMenyChoices.celsius:
                            if (result < -273.15) //-273,15 absoluta noll  Celisus
                            {
                                succes = false;
                            }
                            break;
                        case Meny.TempMenyChoices.farenheit:
                            if (result < -459.67) // -459.67 absoluta noll Fahrenhiet 
                            {
                                succes = false;
                            }
                            break;
                        case Meny.TempMenyChoices.kelvin:
                            if (result < 0)
                            {
                                succes = false; // 0 absoluta noll Kelvin
                            }
                            break;
                    }
                }

                if (!succes)
                {
                   display.ShowMessege(Meny.ErrorMess(tempTyp.ToString(), "temperatur"));
                }


                return succes;


            }

            public bool ReadInput(string typ, string unit, out double result)
            {
                bool succes = double.TryParse(Console.ReadLine(), out result);

                if (succes)
                {
                    if (result < 0)
                    {
                        succes = false;
                    }
                }


                if (!succes)
                {
                   display.ShowMessege(Meny.ErrorMess(typ, unit));
                }


                return succes;


            }
        }

        /*        Huvudmenyn                                            */
        public void MainMeny()
        {

            string menu = "Meny\n1)  Temperatur konvertering\n2)  Längd uträkning\n3)  Beräkna hastighet\n" +
                          "4)  Area\n5)  Volym\n6)  Ohms lag\n7)  Exit\n";

            while (true)
            {
                do
                {
                    display.ClearedDisplay();
                    display.ShowMessege(menu);
                }
                while (!input.ReadInput(out result));


                switch ((MainMenyChoices)result)
                {
                    case MainMenyChoices.temp:
                        TempMeny();
                        break;
                    case MainMenyChoices.length:
                        LengthMeny();
                        break;
                    case MainMenyChoices.speed:
                        SpeedMeny();
                        break;
                    case MainMenyChoices.area:
                        AreaMeny(); 
                        break;
                    case MainMenyChoices.volym:
                        VolymMeny();
                        break;
                    case MainMenyChoices.ohm:
                         ElMeny();
                        break;
                    case MainMenyChoices.exit:
                        Environment.Exit(0);
                        break;
                    default:
                        display.ShowMessege(WRONG_INPUT);
                        break;
                }

            }

        }

        /*        TemperaturMeny                                        */
        public void TempMeny()
        {

            bool run = true;
            string menu = "Tempratur meny\n1) Celsius\n2) Fahrenheit\n3) Kelvin\n4) Till huvudmenyn";

            while (run)
            {

                do
                {
                    display.ClearedDisplay();    
                    display.ShowMessege(menu);
                    //display.ShowMessege("1) Celsius ");
                    //display.ShowMessege("2) Fahrenheit");
                    //display.ShowMessege("3) Kelvin");
                    //display.ShowMessege("4) Till huvudmenyn");
                    
                }
                while (!input.ReadInput(out result));

                 
                switch ((TempMenyChoices)result)
                {
                        case TempMenyChoices.celsius:
                            TempKonvMeny(TempMenyChoices.celsius);
                            break;
                        case TempMenyChoices.farenheit:
                            TempKonvMeny(TempMenyChoices.farenheit);
                            break;
                        case TempMenyChoices.kelvin:
                            TempKonvMeny(TempMenyChoices.kelvin);
                            break;
                        case TempMenyChoices.exit:
                            run = false;
                            break;
                        default:
                            display.ShowMessege(WRONG_INPUT);
                            break;
                }
            
            }
        }

        /*        TemperaturMeny Stöd metod för tempkonverting          */
        public void TempKonvMeny(TempMenyChoices tempTyp)
        {
            double result;

            /*      Tar ett korrekt värde switch ej korrekt loopar om         */
            do
            {
                display.ShowLine($"Ange tempraturen i {tempTyp}: ");
            }
            while (!input.ReadInput(tempTyp, out result));


            switch (tempTyp)
            {
                case TempMenyChoices.celsius:
                    konvert.Celsiuss(result);
                    break;
                case TempMenyChoices.farenheit:
                    konvert.Farenheits(result);
                    break;
                case TempMenyChoices.kelvin:
                    konvert.Kelvins(result);
                    break;
            }

        }

        /*        LängderMeny                                           */
        public void LengthMeny()
        {
            bool run = true;


            while (run)
            {

                do
                {
                    display.ClearedDisplay();
                    display.ShowMessege("Längd Meny\n");
                    display.ShowMessege("1) Centemeter ");
                    display.ShowMessege("2) Meter");
                    display.ShowMessege("3) Inch");
                    display.ShowMessege("4) Yards");
                    display.ShowMessege("5) Foot");
                    display.ShowMessege("6) Till huvudmenyn");
                    
                }
                while (!input.ReadInput(out result));

                switch ((LengthMenyChoices)result)
                {
                case LengthMenyChoices.cm:
                    LenghtKonvMeny(LengthMenyChoices.cm);
                    break;
                case LengthMenyChoices.m:
                    LenghtKonvMeny(LengthMenyChoices.m);
                    break;
                case LengthMenyChoices.inch:
                    LenghtKonvMeny(LengthMenyChoices.inch);
                    break;
                case LengthMenyChoices.yard:
                    LenghtKonvMeny(LengthMenyChoices.yard);
                    break;
                case LengthMenyChoices.foot:
                    LenghtKonvMeny(LengthMenyChoices.foot);
                    break;
                case LengthMenyChoices.exit:
                    run = false;
                    break;
                default:
                        display.ShowMessege(WRONG_INPUT);
                        break;

                }

            }
        }

        /*        LängderMeny  val av lenghtkonverting                  */
        public void LenghtKonvMeny(LengthMenyChoices lengthTyp)
        {
     
            double result;

        /*      Tar ett korrekt värde switch ej korrekt loopar om         */
            do
            {
                Console.Write("Ange längd i {0}: ", lengthTyp.ToString());
            }
            while (!input.ReadInput(lengthTyp.ToString(), "längden", out result));


            switch (lengthTyp)
            {
                case LengthMenyChoices.cm:
                    konvert.Centimeter(result);
                    break;
                case LengthMenyChoices.m:
                    konvert.Meters(result);
                    break;
                case LengthMenyChoices.inch:
                    konvert.Inches(result);
                    break;           
                case LengthMenyChoices.yard:
                    konvert.Yards(result);
                    break;
                case LengthMenyChoices.foot:
                    konvert.Foots(result);
                    break;
                case LengthMenyChoices.exit:
                    break;
            }

        }

        /*        FartMenyn                                             */
        public void SpeedMeny()
        {
            double dataOne, dataTwo;
            bool run = true;


            while (run)
            {

                do
                {
                    display.ClearedDisplay();       
                    display.ShowMessege("SpeedMeny\n");
                    display.ShowMessege("1) Beräkna hastighet");
                    display.ShowMessege("2) Beräkna Tid");
                    display.ShowMessege("3) Beräkna Distans");
                    display.ShowMessege("4) Till huvudmenyn");
                    
                  
                }
                while (!input.ReadInput(out result));

                switch ((SpeedMenyChoices)result)
                {
              
                    case SpeedMenyChoices.speed:
                        do
                        {
                            Console.Write("Ange sträcka i km: ");
                        }
                        while(!input.ReadInput("km", "sträcka", out dataOne));

                        do 
                        {
                            Console.Write("Ange restid i minuter: ");
                        }
                        while (!input.ReadInput("minuter", "restiden", out dataTwo));
                        konvert.Speed(dataOne, dataTwo);
                        break;

                    case SpeedMenyChoices.time:
                        do
                        {
                            Console.Write("Ange sträcka i km: ");
                        }
                        while (!input.ReadInput("km", "sträcka", out dataOne));

                        do
                        {
                            Console.Write("Ange hastigheten i km/h: ");
                        }
                        while (!input.ReadInput("km/h", "hastighet", out dataTwo));
                        konvert.Time(dataOne, dataTwo);
                        break;
                    case SpeedMenyChoices.distance:
                        do
                        {
                            Console.Write("Ange hastighet i km/h: ");
                        }
                        while (!input.ReadInput("km/h", "hastighet", out dataOne));

                        do
                        {
                            Console.Write("Ange resetid i minuter: ");
                        }
                        while (!input.ReadInput("minuter", "resetid", out dataTwo));
                        konvert.Distance(dataOne, dataTwo);
                        break;
                    case SpeedMenyChoices.exit:
                        run = false;
                        break;
                    default:
                        display.ShowMessege(WRONG_INPUT);
                        break;

                }
            }        
        }

        /*         Ytameny                                              */
        public void AreaMeny()
        {
            bool run = true;
            double dataOne, dataTwo;

            while (run)
            {

                do
                {
                    display.ClearedDisplay();
                    display.ShowMessege("Area Meny\n");
                    display.ShowMessege("1) Rektangel ");
                    display.ShowMessege("2) Triangel");
                    display.ShowMessege("3) Cirkel");
                    display.ShowMessege("4) Till huvudmenyn");
                }
                while (!input.ReadInput(out result));

                switch ((AreaAndVolymMenyChoices)result)
                {

                    case AreaAndVolymMenyChoices.rektangel:
                        do
                        {
                            Console.Write("Ange basen i cm: ");
                        }
                        while (!input.ReadInput("cm", "basen", out dataOne));

                        do
                        {
                            Console.Write("Ange höjden i cm: ");
                        }
                        while (!input.ReadInput("cm", "höjden", out dataTwo));
                        konvert.Rektangel(dataOne, dataTwo);
                        break;

                    case AreaAndVolymMenyChoices.triangel:
                        do
                        {
                            Console.Write("Ange basen i cm: ");
                        }
                        while (!input.ReadInput("cm", "basen", out dataOne));

                        do
                        {
                            Console.Write("Ange höjden i cm: ");
                        }
                        while (!input.ReadInput("cm", "höjden", out dataTwo));
                        konvert.Triangel(dataOne, dataTwo);
                        break;
                   
                    case AreaAndVolymMenyChoices.cirkel:
                        do
                        {
                            Console.Write("Ange radien i cm: ");
                        }
                        while (!input.ReadInput("cm", "radie", out dataOne));                   
                        konvert.Cirkel(dataOne);
                        break;

                    case AreaAndVolymMenyChoices.exit:
                        run = false;
                        break;
                    default:
                        display.ShowMessege(WRONG_INPUT);
                        break;

                }

            }
        }

        /*         Volymmeny                                            */
        public void VolymMeny()
        {
            bool run = true;
            double dataOne, dataTwo, dataThree;

            while (run)
            {

                do
                {
                    display.ClearedDisplay();
                    display.ShowMessege("Volym Meny\n");
                    display.ShowMessege("1) Rätblock ");
                    display.ShowMessege("2) Pyramid");
                    display.ShowMessege("3) Sphere");
                    display.ShowMessege("4) Till huvudmenyn");

                }
                while (!input.ReadInput(out result));

                switch ((AreaAndVolymMenyChoices)result)
                {

                    case AreaAndVolymMenyChoices.rektangel:
                        do
                        {
                            Console.Write("Ange basen i cm: ");
                        }
                        while (!input.ReadInput("cm", "basen", out dataOne));
                        do
                        {
                            Console.Write("Ange djup i cm: ");
                        }
                        while (!input.ReadInput("cm", "djup", out dataTwo));
                        do
                        {
                            Console.Write("Ange höjden i cm: ");
                        }
                        while (!input.ReadInput("cm", "höjden", out dataThree));
                        konvert.Kub(dataOne, dataTwo, dataThree);
                        break;

                    case AreaAndVolymMenyChoices.triangel:
                        do
                        {
                            Console.Write("Ange basen i cm: ");
                        }
                        while (!input.ReadInput("cm", "basen", out dataOne));
                        do
                        {
                            Console.Write("Ange djup i cm: ");
                        }
                        while (!input.ReadInput("cm", "djup", out dataTwo));
                        do
                        {
                            Console.Write("Ange höjden i cm: ");
                        }
                        while (!input.ReadInput("cm", "höjden", out dataThree));
                        konvert.Pyramid(dataOne, dataTwo, dataThree);
                        break;

                    case AreaAndVolymMenyChoices.cirkel:
                        do
                        {
                            Console.Write("Ange radien i cm: ");
                        }
                        while (!input.ReadInput("cm", "radie", out dataOne));
                        
                        konvert.Sphere(dataOne);
                        break;
                    case AreaAndVolymMenyChoices.exit:
                        run = false;
                        break;
                    default:
                        display.ShowMessege(WRONG_INPUT);
                        break;

                }

            }
        }

        /*         ElMenyn                                              */
        public void ElMeny()
        {
            bool run = true;
            double dataOne, dataTwo;

            while (run)
            {

                do
                {
                    display.ClearedDisplay();
                    display.ShowMessege("El meny\n");
                    display.ShowMessege("1) Spänning");
                    display.ShowMessege("2) Ström");
                    display.ShowMessege("3) Resistans");
                    display.ShowMessege("4) Till huvudmenyn");

                }
                while (!input.ReadInput(out result));

                switch ((OhmMenyChoices)result)
                {

                    case OhmMenyChoices.voltage:
                        do
                        {
                            Console.Write("Ange strömen i amp: ");
                        }
                        while (!input.ReadInput("amp", "ström", out dataOne));

                        do
                        {
                            Console.Write("Ange resistansen i ohm: ");
                        }
                        while (!input.ReadInput("ohm", "resistansen", out dataTwo));
                        konvert.Voltage(dataOne, dataTwo);
                        break;

                        case OhmMenyChoices.current:
                        do
                        {
                            Console.Write("Ange spänningen i volt: ");
                        }
                        while (!input.ReadInput("volt", "spänning", out dataOne));

                        do
                        {
                            Console.Write("Ange resistansen i ohm: ");
                        }
                        while (!input.ReadInput("ohm", "resistansen", out dataTwo));
                        konvert.Current(dataOne, dataTwo);
                        break;

                        case OhmMenyChoices.resistance:
                        do
                        {
                            Console.Write("Ange spänningen i volt: ");
                        }
                        while (!input.ReadInput("volt", "spänning", out dataOne));

                        do
                        {
                            Console.Write("Ange strömmen i amp: ");
                        }
                        while (!input.ReadInput("amp", "strömmen", out dataTwo));
                        konvert.Resistance(dataOne, dataTwo);
                        break;
                        case OhmMenyChoices.exit:
                        run = false;
                        break;
                    default:
                        display.ShowMessege(WRONG_INPUT);
                        break;

                }

            }
        }
    }
}