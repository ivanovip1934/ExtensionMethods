using System;


namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            double val = 8.0;
            string str = "Alpha Beta Gamma";

            Console.WriteLine($"Обратная величина {val} равна {val.Reciprocal()}");

            Console.WriteLine($"{str} после смены регистра: {str.RevCase()}");

            Console.WriteLine($"Результат вызова метода val.AbsDivideBy(-2): {val.AbsDidideBy(-2)}");

            Console.ReadKey();
        }
    }
}
