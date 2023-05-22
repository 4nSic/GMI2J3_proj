
using System;

namespace Enhetskonvertering
{
    public class Program
    {
        static void Main(string[] args)
        {

            IDisplayHandler displayhandler = new ConsoleDisplayer();
            Meny men = new Meny(displayhandler, new Meny.ConsolInputHandler(displayhandler), new Konverter(displayhandler));

            men.MainMeny();
            
        }
    }

    public class ConsoleDisplayer : IDisplayHandler
    {
        public  string PauseText()
        {
           return "\nTryck på valfri tanget för att komma tillbaka till Menyn.";
        }

        public void ShowLine(string messege)
        {
            Console.WriteLine(messege);
        }

        public void ShowMessege(string messege)
        {
            //Console.Clear();
            Console.WriteLine(messege);
        }
    }
}