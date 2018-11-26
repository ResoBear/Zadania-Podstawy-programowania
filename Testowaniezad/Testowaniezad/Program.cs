using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testowaniezad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program obliczy największy wspólny dzielnik dwóch podanych przez Ciebie liczb całkowitych.");
            Console.WriteLine("Dane wprowadzaj w jednej lini po spacji. Liczby całkowite.");
            Console.WriteLine("Podaj 2 liczby:");
            string dane = Console.ReadLine();

            int wynik = Sprawdzenie(ZamaianaTablic(dane));
            Console.WriteLine("Wynik{0}", wynik);

        }

       static int[] ZamaianaTablic(string a)
        {
            string[] tablicaString = a.Split(' ');
            int[] tablicaInt = Array.ConvertAll(tablicaString, int.Parse);
            return tablicaInt;

        }

         static int Sprawdzenie(int[] a)
        {
            int wynik = 0;

            if (a.Length == 2)
            {
                wynik = NWD(a[0], a[1]);
            }
            else
            {
                Console.WriteLine("Błąd.Musisz podać dwie wartości.");
            }
            return wynik ;
        }

       public static int NWD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }


    }
}
