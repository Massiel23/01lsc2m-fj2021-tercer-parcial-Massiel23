using System;

namespace CalificacionesApp
{
    public sealed class Helpers
    {
        public const int LARGO_DE_LINEA = 60;

        public static void PrintTitle(string title)
        {
            PrintDoubleLine();
            printCenteredText(title, true);
            PrintDoubleLine();
        }

        public static void printSubTitle(string subtitle)
        {
           printCenteredText(subtitle, false);
           printSingleLine();
        }

        private static void printCenteredText(string text, bool upper)
        {
            Console.WriteLine("{0," + (LARGO_DE_LINEA / 2 + text.Length/2) + "}", (upper ? text.ToUpper() : text));
        }

        private static void printSingleLine()
        {
            Console.WriteLine("".PadLeft(LARGO_DE_LINEA, '-'));
        }

        private static void PrintDoubleLine()
        {
            Console.WriteLine("".PadLeft(LARGO_DE_LINEA, '='));
        }
    }
}