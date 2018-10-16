using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba;

            //informacja dla użytkownika
            Console.WriteLine("Program pokazuje czy liczba jest parzysta lub nie.");
            Console.WriteLine("Podaj liczbę całkowitą: ");
            liczba = Convert.ToInt32(Console.ReadLine());
            //sprawdzenie jaka jest liczba
            if (liczba % 2 == 0)
            {
                Console.WriteLine("Liczba {0} jest liczbą parzystą.", liczba);
            }
            else
            {
                Console.WriteLine("Liczba {0} jest liczbą nieparzystą.", liczba);
            }
        }
    }
}
