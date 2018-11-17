using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSSECount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program który pobiera ze standardowego wejścia posortowane linie tekstu\n i na standardowym wyjściu wyświetla linie tekstu z informacją o ilości wystąpień danej linii.");

            string liniaTekstu = "";
            string tekstBiezacy = "";
            int licznik = 0;

            while (liniaTekstu != null)
            {
                Console.WriteLine("Podaj tekst:");
                liniaTekstu = Console.ReadLine();

                if (licznik == 0)
                {
                    licznik++;
                    tekstBiezacy = liniaTekstu;
                }
                else
                {
                    if (liniaTekstu == tekstBiezacy)
                    {
                        licznik++;
                    }
                    else
                    {
                        Console.WriteLine("Wynik = {0} : {1}", tekstBiezacy, licznik);
                        tekstBiezacy = liniaTekstu;
                        licznik = 1;
                    }
                }
            }
        }
    }
}
