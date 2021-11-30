using System;

namespace pz_18._4_задание
{
    class Program
    {
        static double Summ(int n)
        {
            if (n <= 1) return n;
            return n + Summ(n - 1);
        }
        static void Main(string[] args)
        {
            int n = 4;       
            Console.WriteLine(Summ(n));
        }
    }
}
