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

        static void Main(string[] args)
        {
            TombKiiras();
            Osszegzes();
            Megszamlalas();
            Eldontes();

            Console.ReadKey();
        }
    }
}
