using System;

namespace CSharp.Essential.Unit8
{
    public static class ColorPrinter
    {
        public static void Print(string stringToPrint, int color)
//        public static void Print()
        {
//            Console.WriteLine("Welcome to Print method");
            Console.ForegroundColor = (System.ConsoleColor) color;
            Console.WriteLine(stringToPrint);
            Console.ResetColor();
        }
    }
}