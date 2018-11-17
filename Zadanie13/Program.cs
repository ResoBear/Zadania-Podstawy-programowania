using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program liczy wartość sumy i średniej arytmetyczne podanych liczb");
            Console.WriteLine("Podaj liczby całkwite po kolei po spacji: ");

            string wejscie = Console.ReadLine();

            string[] wejTablica = wejscie.Split(' ');
            int[] tablicaInt = Array.ConvertAll(wejTablica, int.Parse);

            int licznik = 0;
            int zliczanie = tablicaInt.Length;
            int suma = 0;

            while (licznik < zliczanie)
            {
                suma = suma + tablicaInt[licznik];
                licznik++;
            }

            Console.WriteLine("Wynik dodawania: {0}", suma);
            double sredniaAryt = suma / tablicaInt.Length;
            Console.WriteLine("Średnia arytmetyczna wynosi: {0}", sredniaAryt);
           
        }
    }
}
