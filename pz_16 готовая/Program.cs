using System;

namespace pz_16_готовая
{
    class Program
    {
        static string danukchmo(string str)
        {
            
                char[] dop;
                char simv;
                int i;
                dop = str.ToCharArray();
                for (i = 0; i < (dop.Length / 2); i++)
                {
                    simv = dop[i];
                    dop[i] = dop[dop.Length - i - 1];
                    dop[dop.Length - i - 1] = simv;

                }
                str = new string(dop);
                return str;

            static void Main(string[] args)
            {

                string fwd = "asdfghj";
                string rvs = danukchmo(fwd);

                Console.WriteLine(fwd);
                Console.WriteLine(rvs);

                Console.ReadKey();

            }
        } 
        
}