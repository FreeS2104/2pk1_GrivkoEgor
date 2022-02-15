using System;
using System.IO;
namespace pz_15
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\komba\OneDrive\Рабочий стол\sort.txt";
            string[] arr = File.ReadAllLines(path);           
            for ( int i = 0 ; i <arr.Length; i++ )
            {
                char[] slime = arr[i].ToCharArray();
                Array.Sort(slime);
                arr[i] = String.Join("", slime);
            }          
            File.WriteAllText(path, String.Join("\n",arr));
            

        }
    }
}
