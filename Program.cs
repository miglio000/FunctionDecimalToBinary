using System;

namespace FunctionDecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int Ndecimal = Convert.ToInt32(Console.ReadLine());
            int remainder;
            string result = string.Empty;
            string input, output;
            while(Ndecimal > 0)
            {
                remainder = Ndecimal % 2;
                Ndecimal /= 2;
                result = remainder.ToString() + result; 
                 input = "8";
                 output = Convert.ToInt32(input, 2).ToString();
            }
            Console.WriteLine($"The number in binary is {output}."); */
            Console.WriteLine("Insert a decimal number:");
            string number = Convert.ToString(Console.ReadLine());
            int FromBase = 10;
            int ToBase;
            Console.WriteLine("In quale base vuoi convertire il numero decimale?");
            ToBase = Convert.ToInt32(Console.ReadLine());
            string result = Convert.ToString(Convert.ToInt32(number, FromBase),ToBase).PadLeft(8,'0');
            Console.WriteLine($"The number in binary is {result}.");
        }
    }
}
