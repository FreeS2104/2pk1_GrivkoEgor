using System;

namespace pz_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = DateTime.Now;
            Console.WriteLine("Введите название вашей организации");
            string name = Console.ReadLine();
            Console.WriteLine("Введите ОКПО вашей организации");
            int okpo = Convert.ToInt32(Console.ReadLine());
            Compony new1 = new Compony(name, okpo, data);
            new1.GetCompanyInfoo();
        }
    }
}
