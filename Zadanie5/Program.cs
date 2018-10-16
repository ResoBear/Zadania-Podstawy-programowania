using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    class Program
    {
        static bool Pierwsza(int n)
        {
            if (n < 2)
            {
                return false; // gdy liczba jest mniejsza niż 2
            }

            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                {
                    return false; //gdy znajdziemy dzielnik
                }
            return true;
        }


        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Podaj liczbę całkowitą:");
            n = Convert.ToInt32(Console.ReadLine());

            if (Pierwsza(n))
            {
                Console.WriteLine("Liczba {0} jest pierwsza", n);
            }
            else
            {
                Console.WriteLine("Liczba {0} nie jest pierwsza", n);
            }
        }
    }
}
