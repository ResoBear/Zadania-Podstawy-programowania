using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b;

            Console.WriteLine("Program pokaże jaki jest stosunek między dwoma liczbami.");

            Console.WriteLine("Podaj liczbę całkowitą A: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj liczbę całkowią B: ");
            b = Convert.ToDouble(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine("Liczba {0} jest większa od {1}.", a, b);
            }

            if (a < b)
            {
                Console.WriteLine("Liczba {0} jest mniejsza od {1}.", a, b);
            }

            if (a == b)
            {
                Console.WriteLine("Liczba {0} jest równa  {1}.", a, b);
            }
        }
    }
}
