using System;

namespace FunctionDecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a decimal number:");
            int Ndecimal = Convert.ToInt32(Console.ReadLine());
            int remainder;
            string result = string.Empty;
            while(Ndecimal > 0)
            {
                remainder = Ndecimal % 2;
                Ndecimal /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine($"The number in binary is {result}.");
        }
    }
}
