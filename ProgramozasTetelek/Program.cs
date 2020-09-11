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

        static void Main(string[] args)
        {
            TombKiiras();
            Osszegzes();

            Console.ReadKey();
        }
    }
}
