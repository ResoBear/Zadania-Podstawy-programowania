using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0, n;

            Console.WriteLine("Program pokazuje sumę nieparzystych liczb n.");

            Console.Write("Podaj liczbę całkowitą dodatnią n: ");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("\nSuma liczb nieparzystych: " + sum);
        }
    }
}
