using System;

namespace Enhetskonvertering
{
    public static class Utilities
    {
        /*    Error meddelande konstant                                              */
        public const string INPUTERROR = "Du har matat in ett felaktigt värde";

        /*        Kalla på ett error meddelande för tempkonv                         */
        public static bool ReadInputTemp(Meny.TempMenyChoices tempTyp, out double result)
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
                Utilities.ErrorMess(tempTyp.ToString(), "temperatur");
            }


            return succes;


        }

        /*        Kalla på ett error meddelande för längder                          */
        public static bool ReadInput(string typ, string unit, out double result)
        {
            bool succes = double.TryParse(Console.ReadLine(), out result);

            if (succes)
            { 
                if(result < 0)
                {
                    succes=false;   
                }
            }


            if (!succes)
            {
                Utilities.ErrorMess(typ, unit);
            }


            return succes;


        }

        /*        Kollar om du har skrivit en en siffra i menyn                      */
        public static bool ReadInput(out int result)
        {
            Console.Write("\nAnge ditt val: ");

            bool succes = int.TryParse(Console.ReadLine(), out result);

            if (!succes)
            {
                ErrorMess();

            }
            Console.WriteLine();
            return succes;
        }

        /*        Kalla på ett error meddelande                                      */
        public static void ErrorMess()
        {
            Console.WriteLine((INPUTERROR + ", välj en siffra i menyn"));
            PauseText();
        }

        /*        Kalla på ett error meddelande för enheter och konverteringar       */
        public static void ErrorMess(string typ, string unit)
        {
            Console.WriteLine(INPUTERROR + ", ang en giltlig {0} i {1}.",unit, typ);
            //PauseText();
        }

        /*        simplyfy text i kovertering                                         */
        public static void PauseText()
        {
            Console.WriteLine("\nTryck på valfri tanget för att komma tillbaka till Menyn.");
            Console.ReadKey();
        }

    }
}