using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cylinderProject
{
    public class cylinder
    {
        // У цилиндра параметр - высота
        public double height;

        // Объём цилиндра
        public double Volume()
        {
            return 3.14 * 5 * 5 * height;
        }

        // Площадь поверхности цилиндра
        public double Surface()
        {
            return 2 * 5 * 3.14 * (height + 5);
        }

    }

    class Testcylinder
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус R");

            double R = double.Parse(Console.ReadLine());

            Console.Write("Введите высту h");

            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("Площадь поверхности цилиндра = {0}", 2 * Math.PI * R * (h + R));

            Console.WriteLine("Объем цилиндра = {0}", Math.PI * R * R * h);
            Console.ReadKey();
        }
    }
    }
}
