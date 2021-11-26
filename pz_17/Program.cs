using System;
namespace pz_17
{
    class Program
    {
        static string ReverseArrayManual(string originalString)
        {
            char[] reversedCharArray = new char[originalString.Length];
            for (int i = originalString.Length - 1; i > -1; i--)
                reversedCharArray[originalString.Length - i - 1] = originalString[i];
            return new string(reversedCharArray);
        }
        static void Main(string[] args)
        {
            string originalString = Console.ReadLine();
            string lolo = ReverseArrayManual(originalString);
            Console.WriteLine(lolo);

        }
    }
}
