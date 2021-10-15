using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massive = new int[30];
            Random rnd = new Random();
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= 29; i++)
            {
                massive[i] = rnd.Next(-50, 50);
                Console.WriteLine(massive[i]);
            }
            Console.WriteLine("Количество положительных чисел:");
            int u = 0;
            for (int k = 0; k <= 29; k++)
            {
                if (massive[k] > 0)
                {
                    u++;
                }
            }
            Console.WriteLine(u);
        }
    }
}
