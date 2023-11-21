using System;

namespace ExpressionsLibrary
{
    public class Expressions
    {
        public static double ArcTgSeries(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(-1, i) / (2 * i + 1);
            }
            return sum;
        }

        public static double BaselSeries(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1 + (1.0 / Math.Pow(i, 2));
            }
            return sum;
        }

        public static int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        public static double SumOfFactorials(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Factorial(i);
            }
            return sum;
        }

    }
}
