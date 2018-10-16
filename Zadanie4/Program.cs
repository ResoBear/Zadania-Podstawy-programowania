using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program służy do rozwiązywania równań kwadratowych w ciele liczb rzeczywistych
            #region inicjowanie zmennych
            double a, b, c;
            double delta;
            double x1, x2;

            #endregion
            //Podanie liczb przez użytkownika
            Console.WriteLine("Obliczanie równania kwadratopwego.");

            Console.WriteLine("Podaj liczbę całkowitą A:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj liczbę całkowitą B:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj liczbę całkowitą C:");
            c = Convert.ToDouble(Console.ReadLine());

            delta = b * b - 4 * a * c;

            #region liczenie rozwiązań
            if (delta < 0)
            {
                // brak rozwiązań rzeczywistych
                Console.WriteLine("Brak rozwiązań żeczywistych");
            }
            if (delta > 0)
            {
                // dwa rozwiązania rzeczywiste
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Dwa rozwiązania rzeczywiste x1 = {0}, x2 = {1}", x1, x2);
            }
            if (delta == 0)
            {
                //jedno podwójne rozwiązanie rzeczywiste
                x1 = -b / (2 * a);
                Console.WriteLine("Jedno rozwiązanie rzeczywiste x1 = {0}", x1);
            }
            #endregion
        }
    }
}
