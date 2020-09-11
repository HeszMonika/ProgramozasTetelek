using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramozasTetelek
{
    class Program
    {
        static int[] tomb = new int[] {12, 7, 2, 4, 45, 99, 1, 8, 95, 50};
        
        static void TombKiiras()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0}, ", tomb[i]);
            }
        }

        static void Osszegzes()
        {
            int ossz = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                ossz = ossz + tomb[i];
            }
            Console.WriteLine("\n{0} ", ossz);
        }

        static void Megszamlalas()
        {
            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]%3 == 0)
                {
                    db++;
                }
            }
            Console.WriteLine("{0} darab 3-mal osztható elem van.", db);
        }

        static void Eldontes()
        {
            int i = 0;
            while (i < tomb.Length && tomb[i] != 69)
            {
                i++;
            }
            if(i < tomb.Length)
            {
                Console.WriteLine("Van 69 az elemek között.");
            }
            else
            {
                Console.WriteLine("Nincs 69 az elemek között.");
            }
        }

        static void Kivalasztas()
        {
            int i = 0;
            while (tomb[i] != 50)
            {
                i++;
            }
            Console.WriteLine("A {0}. indexű helyen van.", i);
        }

        static void Kereses()
        {
            int i = 0;
            while (i < tomb.Length && tomb[i] != 50)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine("Benne van az 50 a {0}. helyen / a {1} indexű helyen.", i + 1, i);
            }
            else
            {
                Console.WriteLine("Nincs benne a tömbben.");
            }
        }

        static void Maximum()
        {
            int max = 1;
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] > max)
                {
                    max = tomb[i];
                }
            }
            Console.WriteLine("A tömb legnagyobb eleme a(z) {0}.", max);
        }

        static void Minimum()
        {
            int min = 1;
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i] < min)
                {
                    min = tomb[i];
                }
            }
            Console.WriteLine("A tömb legkisebb eleme a(z) {0}.", min);
        }

        static void Main(string[] args)
        {
            TombKiiras();
            Osszegzes();
            Megszamlalas();
            Eldontes();
            Kivalasztas();
            Kereses();
            Maximum();
            Minimum();

            Console.ReadKey();
        }
    }
}
