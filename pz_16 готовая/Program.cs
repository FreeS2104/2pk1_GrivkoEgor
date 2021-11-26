using System;

namespace pz_16_готовая
{
    class Program
    {
        static void GetLimetSumm(int n, out int ss)
        {
            ss = 0;
            for (int i = 0; i <= n; i++)
            {
                ss += i;
            }
            Console.WriteLine(ss);
        }
        static void Main(string[] args)
        {
            int sum;
            Console.WriteLine("Ведите число до которого хотите посчитать сумму :");
            int n = Convert.ToInt32(Console.ReadLine());
            GetLimetSumm(n, out sum);
        }
    }
        
}