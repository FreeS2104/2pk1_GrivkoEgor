using System;
using System.IO;


namespace PZ_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathToInput = @"C:\Users\grivko.es1226\Desktop\Egor\input.txt";
            string pathToOutput = @"C:\Users\grivko.es1226\Desktop\Egor\output.txt";
            int[] nums = new int[100];
            File.Delete(pathToInput);
            using (StreamWriter sw = File.AppendText(pathToInput))
            {
                Random rand = new Random();
                for (int i = 0; i < 100; i++)
                {
                    nums[i] = rand.Next(0, 101);
                    sw.WriteLine(nums[i]);
                }
            }
            Array.Sort(nums);

            using (StreamWriter sw = File.AppendText(pathToOutput))
            {
                for (int i = 0; i < nums.Length; i++)
                    sw.WriteLine(nums[i]);
            }
        }
    }
}
