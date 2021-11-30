using System;

namespace pz_18
{
    class Program
    {
        static double Arifm(int n, double a, double d)
        {
            if (n < 1) return 0; //для неположительных номеров
            else if (n == 1) return a; //базовый случай n=1
            return Arifm(n - 1, a, d) + d; //общий случай
        }
        static void Main(string[] args)
        {
            double d = -1;
            double a = -8;
            int n = Convert.ToInt32(Console.ReadLine());
            double r = Arifm(n, a, d);
            Console.WriteLine(r);
        }
    }
}
