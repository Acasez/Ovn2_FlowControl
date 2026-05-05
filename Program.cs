
using Ovn2_FlowControl;
using System;

namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            const string loopIntro = "Välkommen till huvudmenyn. \n" +
                "Skriv en siffra för att välja funktion. \n" +
                "0 = Avsluta \n" +
                "1 = Pris för en person \n" +
                "2 = Pris för sällskap \n" +
                "3 = Upprepa tio gånger \n" +
                "4 = Det tredje ordet";
            while (running)
            {
                LoopDisplay(running, loopIntro);
            }
        }

        public static bool LoopDisplay(bool running, string loopIntro)
        {
            Console.WriteLine(loopIntro);
            Console.Write("Ditt val: ");

            string? input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    running = false;
                    Console.WriteLine("Programmet avslutas.");
                    break;
                case "1":
                    Biopriser.ReturneraPris();
                    break;
                case "2":
                    Biopriser.PrisForSallskap();
                    break;
                case "3":
                    Textmanipulation.UpprepaTioGanger();
                    break;
                case "4":
                    Textmanipulation.DetTredjeOrdet();
                    break;
                default:
                    Helper.WriteErrorMessage("Felaktig input, välj 0-4.");
                    break;
            }

            Console.WriteLine();
            return running;
        }
    }
}

