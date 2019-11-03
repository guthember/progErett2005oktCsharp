using System;
using System.Collections.Generic;

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


        static string EkezetCsere(string szoveg)
        {
            Dictionary<char, char> helyett = new Dictionary<char, char>
            {
                {'Á','A' }, {'É','E'}, {'Í','I'}, {'Ó','O'}, {'Ö','O'}, {'Ő', 'O'}, {'Ú', 'U'}, {'Ü','U'}, {'Ű','U'}
            };

            string alakitott = "";

            foreach (var ch in szoveg)
            {
                if (helyett.ContainsKey(ch))
                {
                    alakitott += helyett[ch].ToString();
                }
                else
                {
                    alakitott += ch.ToString();
                }
            }

            return alakitott;
        }

        static string EgyebKarakter(string szoveg)
        {
            string alakitott = "";
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            foreach (var ch in szoveg)
            {
                if (abc.Contains(ch))
                {
                    alakitott += ch.ToString();
                }
            }

            return alakitott;
        }

        static void Masodik()
        {
            Console.WriteLine("\n2. feladat");
            Console.WriteLine("Átalakítás...");
            nyiltSzoveg = nyiltSzoveg.ToUpper();
            nyiltSzoveg = EkezetCsere(nyiltSzoveg);
            nyiltSzoveg = EgyebKarakter(nyiltSzoveg);

            Console.WriteLine(nyiltSzoveg);

        }

        static void Main(string[] args)
        {
            Elso();
            Masodik();

            Console.ReadKey();
        }
    }
}
