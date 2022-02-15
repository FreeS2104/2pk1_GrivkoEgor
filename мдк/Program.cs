using System;

namespace мдк
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Введите радиус R");

            double R = double.Parse(Console.ReadLine());

            if (R < 0)
            {
                Console.WriteLine($"Числа введены не корректно перезапустите программу");
            }
            if (R < 0)
            {
                 R = 0;
            }
            Console.Write("Введите высту h");


                double h = double.Parse(Console.ReadLine());
            if (h < 0)
            {
                Console.WriteLine($"Числа введены не корректно перезапустите программу");
            }
            if (h < 0)
            {
                h = 0;
            }    
            Console.WriteLine("Площадь поверхности цилиндра = {0}", 2 * Math.PI * R * (h + R));

                Console.WriteLine("Объем цилиндра = {0}", Math.PI * R * R * h);

                Console.ReadKey();

            
        }
    }
}
