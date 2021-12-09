using System;

namespace pz_18._3_задание
{
    class Program
    {
        static void Bomba(int a, int b)
        {
            Console.WriteLine(a);
            if (a == b) return;
            Bomba(b > a ? a + 1 : a - 1, b) ; 
        }
        static void Main(string[] args)
        {
            Bomba(60, 0);
 
        }
    }
}
