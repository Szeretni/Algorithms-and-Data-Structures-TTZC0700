using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtavat1
{
    public static class Assignment5
    {
        public static void Assignment5a(int k)
        {
            Console.WriteLine("Assignment 5a");
            int firstInt = 0;
            int secondInt = 1;
            int tempInt = 0;
            List<int> ints = new List<int>
            {
                firstInt,
                secondInt
            };

            for (int i = 0; i < k - 2; i++)
            {
                tempInt = secondInt;
                secondInt += firstInt;
                firstInt = tempInt;
                ints.Add(secondInt);
            }

            int index = 1;
            foreach (int i in ints)
            {
                Console.WriteLine(index + ". number is: " + i);
                index++;
            }
        }

        public static void Assignment5b(int k)
        {
            Console.WriteLine("Assignment 5b");
            int firstInt = 0;
            int secondInt = 1;
            int tempInt = 0;

            for (int i = 0; i < k - 2; i++)
            {
                tempInt = secondInt;
                secondInt += firstInt;
                firstInt = tempInt;
            }
            if (k == 1)
            {
                Console.WriteLine(k + ". number is: " + firstInt);
            }
            else if (k == 2)
            {
                Console.WriteLine(k + ". number is: " + secondInt);
            }
            else
            {
                Console.WriteLine(k + ". number is: " + secondInt);
            }
        }

        public static void Assignment5c(int k, int firstInt, int secondInt, int initialK)
        {
            int tempInt = 0;

            if (k == 1)
            {
                Console.WriteLine("Assignment5c\n" + initialK + ". number is: " + firstInt);
            }
            else if (k == 2)
            {
                Console.WriteLine("Assignment5c\n" + initialK + ". number is: " + secondInt);
            }
            else
            {
                tempInt = secondInt;
                secondInt += firstInt;
                firstInt = tempInt;
                k--;
                Assignment5c(k, firstInt, secondInt, initialK);
            }
        }
    }
}
