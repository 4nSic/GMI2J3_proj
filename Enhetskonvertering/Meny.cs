using System;

namespace Enhetskonvertering
{
    public struct Meny
    {
        private static int result;

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

        /*        Huvudmenyn                                            */
        public static void MainMeny()
        {
            
            while (true)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Meny\n");
                    Console.WriteLine("1)  Temperatur konvertering");
                    Console.WriteLine("2)  Längd uträkning");
                    Console.WriteLine("3)  Beräkna hastighet");
                    Console.WriteLine("4)  Area");
                    Console.WriteLine("5)  Volym");
                    Console.WriteLine("6)  Ohms lag");
                    Console.WriteLine("7)  Exit");
                    

                }
                while (!Utilities.ReadInput(out result));


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
                        Utilities.ErrorMess();
                        break;
                }

            }

        }

        /*        TemperaturMeny                                        */
        public static void TempMeny()
        {

            bool run = true;


            while (run)
            {

                do
                {
                    Console.Clear();
                    Console.WriteLine("Tempratur meny\n");
                    Console.WriteLine("1) Celsius ");
                    Console.WriteLine("2) Fahrenheit");
                    Console.WriteLine("3) Kelvin");
                    Console.WriteLine("4) Till huvudmenyn");
                    
                }
                while (!Utilities.ReadInput(out result));

                 
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
                        Utilities.ErrorMess();
                            break;
                }
            
            }
        }

        /*        TemperaturMeny Stöd metod för tempkonverting          */
        public static void TempKonvMeny(TempMenyChoices tempTyp)
        {
            double result;

            /*      Tar ett korrekt värde switch ej korrekt loopar om         */
            do
            {
                Console.Write("Ange tempraturen i {0}: ", tempTyp.ToString());
            }
            while (!Utilities.ReadInputTemp(tempTyp, out result));


            switch (tempTyp)
            {
                case TempMenyChoices.celsius:
                    Konverter.Celsiuss(result);
                    break;
                case TempMenyChoices.farenheit:
                    Konverter.Farenheits(result);
                    break;
                case TempMenyChoices.kelvin:
                    Konverter.Kelvins(result);
                    break;
            }

        }

        /*        LängderMeny                                           */
        public static void LengthMeny()
        {
            bool run = true;


            while (run)
            {

                do
                {
                    Console.Clear();
                    Console.WriteLine("Längd Meny\n");
                    Console.WriteLine("1) Centemeter ");
                    Console.WriteLine("2) Meter");
                    Console.WriteLine("3) Inch");
                    Console.WriteLine("4) Yards");
                    Console.WriteLine("5) Foot");
                    Console.WriteLine("6) Till huvudmenyn");
                    
                }
                while (!Utilities.ReadInput(out result));

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
                        Utilities.ErrorMess();
                    break;

                }

            }
        }

        /*        LängderMeny  val av lenghtkonverting                  */
        public static void LenghtKonvMeny(LengthMenyChoices lengthTyp)
        {
     
            double result;

        /*      Tar ett korrekt värde switch ej korrekt loopar om         */
            do
            {
                Console.Write("Ange längd i {0}: ", lengthTyp.ToString());
            }
            while (!Utilities.ReadInput(lengthTyp.ToString(), "längden", out result));


            switch (lengthTyp)
            {
                case LengthMenyChoices.cm:
                    Konverter.Centimeter(result);
                    break;
                case LengthMenyChoices.m:
                    Konverter.Meters(result);
                    break;
                case LengthMenyChoices.inch:
                    Konverter.Inches(result);
                    break;           
                case LengthMenyChoices.yard:
                    Konverter.Yards(result);
                    break;
                case LengthMenyChoices.foot:
                    Konverter.Foots(result);
                    break;
                case LengthMenyChoices.exit:
                    break;
            }

        }

        /*        FartMenyn                                             */
        public static void SpeedMeny()
        {
            double dataOne, dataTwo;
            bool run = true;


            while (run)
            {

                do
                {
                    Console.Clear();
                    Console.WriteLine("SpeedMeny\n");
                    Console.WriteLine("1) Beräkna hastighet");
                    Console.WriteLine("2) Beräkna Tid");
                    Console.WriteLine("3) Beräkna Distans");
                    Console.WriteLine("4) Till huvudmenyn");
                    
                  
                }
                while (!Utilities.ReadInput(out result));

                switch ((SpeedMenyChoices)result)
                {
              
                    case SpeedMenyChoices.speed:
                        do
                        {
                            Console.Write("Ange sträcka i km: ");
                        }
                        while(!Utilities.ReadInput("km", "sträcka", out dataOne));

                        do 
                        {
                            Console.Write("Ange restid i minuter: ");
                        }
                        while (!Utilities.ReadInput("minuter", "restiden", out dataTwo));
                        Konverter.Speed(dataOne, dataTwo);
                        break;

                    case SpeedMenyChoices.time:
                        do
                        {
                            Console.Write("Ange sträcka i km: ");
                        }
                        while (!Utilities.ReadInput("km", "sträcka", out dataOne));

                        do
                        {
                            Console.Write("Ange hastigheten i km/h: ");
                        }
                        while (!Utilities.ReadInput("km/h", "hastighet", out dataTwo));
                        Konverter.Time(dataOne, dataTwo);
                        break;
                    case SpeedMenyChoices.distance:
                        do
                        {
                            Console.Write("Ange hastighet i km/h: ");
                        }
                        while (!Utilities.ReadInput("km/h", "hastighet", out dataOne));

                        do
                        {
                            Console.Write("Ange resetid i minuter: ");
                        }
                        while (!Utilities.ReadInput("minuter", "resetid", out dataTwo));
                        Konverter.Distance(dataOne, dataTwo);
                        break;
                    case SpeedMenyChoices.exit:
                        run = false;
                        break;
                    default:
                        Utilities.ErrorMess();
                        break;

                }
            }        
        }

        /*         Ytameny                                              */
        public static void AreaMeny()
        {
            bool run = true;
            double dataOne, dataTwo;

            while (run)
            {

                do
                {
                    Console.Clear();
                    Console.WriteLine("Area Meny\n");
                    Console.WriteLine("1) Rektangel ");
                    Console.WriteLine("2) Triangel");
                    Console.WriteLine("3) Cirkel");
                    Console.WriteLine("4) Till huvudmenyn");
                }
                while (!Utilities.ReadInput(out result));

                switch ((AreaAndVolymMenyChoices)result)
                {

                    case AreaAndVolymMenyChoices.rektangel:
                        do
                        {
                            Console.Write("Ange basen i cm: ");
                        }
                        while (!Utilities.ReadInput("cm", "basen", out dataOne));

                        do
                        {
                            Console.Write("Ange höjden i cm: ");
                        }
                        while (!Utilities.ReadInput("cm", "höjden", out dataTwo));
                        Konverter.Rektangel(dataOne, dataTwo);
                        break;

                    case AreaAndVolymMenyChoices.triangel:
                        do
                        {
                            Console.Write("Ange basen i cm: ");
                        }
                        while (!Utilities.ReadInput("cm", "basen", out dataOne));

                        do
                        {
                            Console.Write("Ange höjden i cm: ");
                        }
                        while (!Utilities.ReadInput("cm", "höjden", out dataTwo));
                        Konverter.Triangel(dataOne, dataTwo);
                        break;
                   
                    case AreaAndVolymMenyChoices.cirkel:
                        do
                        {
                            Console.Write("Ange radien i cm: ");
                        }
                        while (!Utilities.ReadInput("cm", "radie", out dataOne));                   
                        Konverter.Cirkel(dataOne);
                        break;

                    case AreaAndVolymMenyChoices.exit:
                        run = false;
                        break;
                    default:
                        Utilities.ErrorMess();
                        break;

                }

            }
        }

        /*         Volymmeny                                            */
        public static void VolymMeny()
        {
            bool run = true;
            double dataOne, dataTwo, dataThree;

            while (run)
            {

                do
                {
                    Console.Clear();
                    Console.WriteLine("Volym Meny\n");
                    Console.WriteLine("1) Rätblock ");
                    Console.WriteLine("2) Pyramid");
                    Console.WriteLine("3) Sphere");
                    Console.WriteLine("4) Till huvudmenyn");

                }
                while (!Utilities.ReadInput(out result));

                switch ((AreaAndVolymMenyChoices)result)
                {

                    case AreaAndVolymMenyChoices.rektangel:
                        do
                        {
                            Console.Write("Ange basen i cm: ");
                        }
                        while (!Utilities.ReadInput("cm", "basen", out dataOne));
                        do
                        {
                            Console.Write("Ange djup i cm: ");
                        }
                        while (!Utilities.ReadInput("cm", "djup", out dataTwo));
                        do
                        {
                            Console.Write("Ange höjden i cm: ");
                        }
                        while (!Utilities.ReadInput("cm", "höjden", out dataThree));
                        Konverter.Kub(dataOne, dataTwo, dataThree);
                        break;

                    case AreaAndVolymMenyChoices.triangel:
                        do
                        {
                            Console.Write("Ange basen i cm: ");
                        }
                        while (!Utilities.ReadInput("cm", "basen", out dataOne));
                        do
                        {
                            Console.Write("Ange djup i cm: ");
                        }
                        while (!Utilities.ReadInput("cm", "djup", out dataTwo));
                        do
                        {
                            Console.Write("Ange höjden i cm: ");
                        }
                        while (!Utilities.ReadInput("cm", "höjden", out dataThree));
                        Konverter.Pyramid(dataOne, dataTwo, dataThree);
                        break;

                    case AreaAndVolymMenyChoices.cirkel:
                        do
                        {
                            Console.Write("Ange radien i cm: ");
                        }
                        while (!Utilities.ReadInput("cm", "radie", out dataOne));
                        
                        Konverter.Sphere(dataOne);
                        break;
                    case AreaAndVolymMenyChoices.exit:
                        run = false;
                        break;
                    default:
                        Utilities.ErrorMess();
                        break;

                }

            }
        }

        /*         ElMenyn                                              */
        public static void ElMeny()
        {
            bool run = true;
            double dataOne, dataTwo;

            while (run)
            {

                do
                {
                    Console.Clear();
                    Console.WriteLine("El meny\n");
                    Console.WriteLine("1) Spänning");
                    Console.WriteLine("2) Ström");
                    Console.WriteLine("3) Resistans");
                    Console.WriteLine("4) Till huvudmenyn");

                }
                while (!Utilities.ReadInput(out result));

                switch ((OhmMenyChoices)result)
                {

                    case OhmMenyChoices.voltage:
                        do
                        {
                            Console.Write("Ange strömen i amp: ");
                        }
                        while (!Utilities.ReadInput("amp", "ström", out dataOne));

                        do
                        {
                            Console.Write("Ange resistansen i ohm: ");
                        }
                        while (!Utilities.ReadInput("ohm", "resistansen", out dataTwo));
                        Konverter.Voltage(dataOne, dataTwo);
                        break;

                        case OhmMenyChoices.current:
                        do
                        {
                            Console.Write("Ange spänningen i volt: ");
                        }
                        while (!Utilities.ReadInput("volt", "spänning", out dataOne));

                        do
                        {
                            Console.Write("Ange resistansen i ohm: ");
                        }
                        while (!Utilities.ReadInput("ohm", "resistansen", out dataTwo));
                        Konverter.Current(dataOne, dataTwo);
                        break;

                        case OhmMenyChoices.resistance:
                        do
                        {
                            Console.Write("Ange spänningen i volt: ");
                        }
                        while (!Utilities.ReadInput("volt", "spänning", out dataOne));

                        do
                        {
                            Console.Write("Ange strömmen i amp: ");
                        }
                        while (!Utilities.ReadInput("amp", "strömmen", out dataTwo));
                        Konverter.Resistance(dataOne, dataTwo);
                        break;
                        case OhmMenyChoices.exit:
                        run = false;
                        break;
                    default:
                        Utilities.ErrorMess();
                        break;

                }

            }
        }
    }
}