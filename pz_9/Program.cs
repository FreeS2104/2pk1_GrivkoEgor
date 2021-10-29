using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 2, 121, 19, 4, -1, 1, 22, 32, -24, 62 };// массив
            double max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) > Math.Abs(max))
                    max = array[i];
            }
            Console.WriteLine("max= {0}", max);
            int x = 0, y = 0; // x=строчка, y=номер в строчке
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    x = i;
                    for (int j = x + 1; j < array.Length; j++)
                    {
                        if (array[j] > 0)
                        {
                            y = j;
                            break;
                        }
                    }
                    break;
                }
            }
            Console.WriteLine($"x={ x}\ny={ y} ");// вывод значения строки и номера
            for (int i = 0; i < array.Length; i++)
            {
                
                if (i == 5)
                {
                    Console.WriteLine();
                }
                Console.Write(array[i] + "\t");// написал в 2 строки
            }


            Console.ReadLine();
        }
    }
}
