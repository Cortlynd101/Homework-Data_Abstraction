using System;
using static System.Console;
using System.IO;

namespace AllHW
{
    internal class HomeWorkThree
    {
        public static int ProblemFour(int start, int end)
        {
            if (end > start)
            {
                return end + ProblemFour(start, end - 1);
            }
            else
            {
                return start;
            }
        }

        public static decimal ProblemSeven(decimal n)
        {
            if (n > 1)
            {
                return 1/n + ProblemSeven(n-1);
            }
            else
            {
                return n;
            }
        }

        public static double power1(double x, double n) //ProblemEighteen a.
        {
            double newX = 1;
            for (int i = 0; i < n; i++)
            {
                newX = newX * x;
            }
            return newX;
        }
        public static double power2(double x, double n) //ProblemEighteen b.
        {
            if (n > 0)
            {
                return x * power2(x, n-1);
            }
            else
            {
                return 1;
            }
        }
        public static double power3(double x, double n) //ProblemEighteen c.
        {
            if (n > 0 & n % 2 == 0)
            {
                return Math.Pow(power3(x, n/2), 2);
            }
            else if (n > 0 & n % 2 != 0)
            {
                return x * Math.Pow(power3(x, n/2), 2);
            }
            else 
            {
                return 1;
            }
        }
    }
}