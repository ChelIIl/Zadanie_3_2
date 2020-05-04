using System;

namespace СSh
{
    class Program
    {
        static double f (double x)
        {
            double y = 0;

            if ((x + 2) <= 1)
                y = x * x;
            else if (1 < (x + 2) && (x + 2) < 10)
                y = 1 / (x + 2);
            else
                y = x + 2;

            return y;
        }

        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());

            for (double i = a; i <= b; i += h)
                Console.WriteLine("f({0}) = {1}", i, f(i));

            Console.ReadKey();
        }
    }
}
