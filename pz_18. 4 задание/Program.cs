using System;

namespace pz_18._4_задание
{
    class Program
    {
        static void Reverse(int number)
        {
            int newNum = number % 10;
            Console.Write(newNum);
            number /= 10;

            if (number > 0)
                Reverse(number);
        }
        static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Reverse(a);
            Console.ReadKey();
        }

    }
}
