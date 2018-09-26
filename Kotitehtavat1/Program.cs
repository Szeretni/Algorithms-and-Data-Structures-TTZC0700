using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtavat1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 9;
            int firstInt = 0;
            int secondInt = 1;

            Assignment5.Assignment5a(k);
            Assignment5.Assignment5b(k);
            Assignment5.Assignment5c(k, firstInt, secondInt, k);

            Assignment6.Juuri(2, 0.00001);
        }
    }
}
