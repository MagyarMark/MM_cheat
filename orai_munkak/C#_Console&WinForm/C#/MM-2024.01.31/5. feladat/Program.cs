using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _5.feladat
{
    internal class Program
    {
        static string megforditottszoveg(string szo)
        {
            char[] karakterek = szo.ToCharArray();
            Array.Reverse(karakterek);

            return new string(karakterek);
        }
        static void Main(string[] args)
        {
            string eredeti = "Géza kék az ég";
            string megforditottszo = megforditottszoveg(eredeti);

            Console.WriteLine("eredeti: " + eredeti);
            Console.WriteLine("megfordított: " + megforditottszo);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
