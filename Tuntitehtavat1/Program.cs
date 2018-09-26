using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TietorakenteetAlgoritmit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(murtoluku(5));
        }

        private static double murtoluku(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            double nimittaja = 1;
            double osoittaja = 1;
            for (int k = 1; k <= n; k++)
            {
                double tilap = nimittaja;
                nimittaja = nimittaja + osoittaja;
                osoittaja = tilap;
            }
            double vastaus = osoittaja / nimittaja;
            return vastaus;
        }
    }
}
