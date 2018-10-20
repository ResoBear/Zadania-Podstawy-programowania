using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Program konwertuje liczbę dziesiętną na binarną.");
            Console.Write("Podaj liczbę całkowitą dodatnią: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            int remainder;
            string result = ("");
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Postać binarna:  {0}", result);
        }
    }
}
