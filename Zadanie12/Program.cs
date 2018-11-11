using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie12
{
    class Program
    {
        public static int minmax(int a, int b)
        {
            int wyn = 0;
            while(a <= b)
            {
                wyn = a + wyn;
                a++;
            }
            
            return wyn;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program oblicza sumę liczb całkowitych n.\nZawartych pomiędzy minimum a maximum./n/n");
            Console.WriteLine("Podaj liczbę całkwitą dodatnią min i max.");

            Console.WriteLine("Min: ");
            int min;
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Max: ");
            int max;
            max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wynik {0}", minmax(min, max));

        }
    }
}
