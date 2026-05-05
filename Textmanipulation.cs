using System;
using System.Collections.Generic;
using System.Text;

namespace Ovn2_FlowControl
{
    internal class Textmanipulation
    {
        public static void UpprepaTioGanger()
        {
            Console.Write("Skriv en text: ");
            string? text = Console.ReadLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}. {text} ");
            }

            Console.WriteLine();
        }

        public static void DetTredjeOrdet()
        {
            Console.Write("Skriv en mening med minst 3 ord: ");
            string? mening = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(mening))
            {
                Helper.WriteErrorMessage("Du måste skriva en mening.");
                return;
            }

            string[] ord = mening.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (ord.Length < 3)
            {
                Console.WriteLine("Mening måste innehålla minst 3 ord.");
                return;
            }

            Console.WriteLine($"Det tredje ordet är: {ord[2]}");
        }
    }
}
