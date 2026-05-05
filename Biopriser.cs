using System;
using System.Collections.Generic;
using System.Text;

namespace Ovn2_FlowControl
{
    internal class Biopriser
    {
        public static int? ReturneraPris()
        {
            int freePrice = 0;
            int youthPrice = 80;
            int seniorPrice = 90;
            int adultPrice = 120;

            Console.Write("Ange ålder: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int alder))    // Jämför med int.Parse(input) --> "hej" --> Exception
            {
                Console.WriteLine("Ogiltig ålder.");
                return null;
            }

            if (alder < 20)
            {
                if (alder < 5)
                {
                    Console.WriteLine("Barn kan se gratis!");
                    return freePrice;
                }
                Console.WriteLine("Ungdomspris: 80kr");
                return youthPrice;
            }
            else if (alder > 64)
            {
                if (alder > 100)
                {
                    Console.WriteLine("Grattis, du kan också se gratis!");
                    return freePrice;
                }
                Console.WriteLine("Pensionärspris: 90kr");
                return seniorPrice;
            }
            else
            {
                Console.WriteLine("Standardpris: 120kr");
                return adultPrice;
            }
        }

        public static void PrisForSallskap()
        {
            Console.Write("Hur många personer är ni? ");
            string? antalInput = Console.ReadLine();

            if (!int.TryParse(antalInput, out int antal) || antal <= 0)
            {
                Helper.WriteErrorMessage("Ogiltigt antal personer.");
                return;
            }

            int total = 0;

            for (int i = 1; i <= antal; i++)
            {
                Console.Write("Person " + i + " - ");
                int? returnedCost = null;
                while (returnedCost == null)
                {
                    returnedCost = ReturneraPris();
                }
                total += (int)returnedCost;
            }

            Console.WriteLine($"Antal personer: {antal}");
            Console.WriteLine($"Totalkostnad: {total} kr");
        }
    }
}
