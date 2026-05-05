using System;
using System.Collections.Generic;
using System.Text;

namespace Ovn2_FlowControl
{
    internal class Helper
    {
        public static void WriteErrorMessage(string errorText)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorText);
            Console.ResetColor();
        }
    }
}
