using System;

namespace kodol
{
    class Program
    {
        static string nyiltSzoveg;

        static void Elso()
        {
            Console.WriteLine("1. feladat");
            Console.Write("Kérek egy max 255 karakter szöveget: ");
            nyiltSzoveg = Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Elso();

            Console.ReadKey();
        }
    }
}
