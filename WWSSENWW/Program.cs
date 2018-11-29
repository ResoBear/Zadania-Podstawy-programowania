using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSSENWW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program obliczający największa wspólna wielokrotność dla przekazanych parametrów w linii polecenia.");
            Console.WriteLine("Dane wprowadzaj w jednej lini po spacji. Liczby całkowite.");
            Console.WriteLine("Podaj 2 liczby:");
            string dane = Console.ReadLine();

            int a = X(ZamaianaTablic(dane));
            int b = Y(ZamaianaTablic(dane));

            if (a > b)
            {
                int pom = a;
                a = b;
                b = pom;
            }

            int wynNwd = Sprawdzenie(ZamaianaTablic(dane));
            int wynikNww = NWW(a, b, wynNwd);
            Console.WriteLine("NWW jest równe {0}", wynikNww);

        }

        public static int[] ZamaianaTablic(string a)
        {
            string[] tablicaString = a.Split(' ');
            int[] tablicaInt = Array.ConvertAll(tablicaString, int.Parse);
            return tablicaInt;

        }

        static int X(int[] a)
        {
            int x = a[0];
            return x;

        }

        static int Y(int[] a)
        {
            int y = a[1];
            return y;

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
            return wynik;
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
        static int NWW(int x, int y, int z)
        {
            int wynikNWW = (x / z) * y;
            return wynikNWW;
        }


    }
}
