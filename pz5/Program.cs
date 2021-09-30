using System;

namespace pz5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, r, y, j ,m;
            char smv = 'c';
            //// 1 задание
            Console.WriteLine("\nЗадние 1:");
            int k;
            for (k = 0; k <= 80; k += 4)
            {
                Console.WriteLine(k);
            }
            ///2 задание Вводим  число 3 и полчим ответ
            Console.WriteLine("\nЗадние 2:");
            n = 0;
            while (n<=5)
            {
                n += 1;
                Console.Write(smv + " ");
                smv++;

            }
            Console.WriteLine("\nЗадние 3:");
            /// 3 задание 
            for (m = 0; m <= 4; m++)
            {
                for (int o = 0; o <= 2; o++) Console.Write("##");
                Console.WriteLine("");
            }
            /// 4 задание
              Console.WriteLine("\nЗадние 4:");
            for (i = 0; i <= 100; i++)
            {
                if (i == 0) continue;
                if ((i % 5) != 0) continue;
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("\nЗадние 5:");
            /// 5 задание
            i = 1;
            j = 40;
            for (j = 1, j = 40; j - i > 14; i++, j--) 
            {
                Console.WriteLine("i и y равны :" + i + " и " + j);
            }

        }      
    }      
                
}
