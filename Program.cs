
using System;

namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Välkommen till huvudmenyn.");
                Console.WriteLine("Skriv en siffra för att välja funktion.");
                Console.WriteLine("0 = Avsluta");
                Console.WriteLine("1 = Ungdom eller pensionär");
                Console.WriteLine("2 = Pris för sällskap");
                Console.WriteLine("3 = Upprepa tio gånger");
                Console.WriteLine("4 = Det tredje ordet");
                Console.Write("Ditt val: ");

                string? input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        running = false;
                        Console.WriteLine("Programmet avslutas.");
                        break;

                    case "1":
                        ReturneraPris();
                        break;

                    case "2":
                        PrisForSallskap();
                        break;

                    case "3":
                        UpprepaTioGanger();
                        break;

                    case "4":
                        DetTredjeOrdet();
                        break;

                    default:
                        Console.WriteLine("Felaktig input, välj 0-4.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static int? ReturneraPris()
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

        static void PrisForSallskap()
        {
            Console.Write("Hur många personer är ni? ");
            string? antalInput = Console.ReadLine();

            if (!int.TryParse(antalInput, out int antal) || antal <= 0)
            {
                Console.WriteLine("Ogiltigt antal personer.");
                return;
            }

            int total = 0;

            for (int i = 1; i <= antal; i++)
            {
                Console.Write("Person " + i);
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

        static void UpprepaTioGanger()
        {
            Console.Write("Skriv en text: ");
            string? text = Console.ReadLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}. {text} ");
            }

            Console.WriteLine();
        }

        static void DetTredjeOrdet()
        {
            Console.Write("Skriv en mening med minst 3 ord: ");
            string? mening = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(mening))
            {
                Console.WriteLine("Du måste skriva en mening.");
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

