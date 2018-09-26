using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtavat1
{
    static class Assignment6
    {
        public static void Juuri(double a, double tolerance)
        {
            double oldValue = 1;
            while (true)
            {
                double newValue = 0.5 * (oldValue + (a / oldValue));
                double difference = newValue - oldValue;
                Console.WriteLine("Initial value {0:0.00000} : new value {1:0.00000} : old value {2:0.00000} : difference {3:0.00000} : tolerance {4:0.00000}", a, newValue, oldValue, difference, tolerance);
                if (difference <= tolerance && (difference >= tolerance * -1))
                {
                    break;
                }
                else
                {
                    oldValue = newValue;
                }
            }
        }
    }
}
