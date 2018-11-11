using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            string i = "";
            Console.WriteLine("Podaj dowolną cyfrę binarną: ");
            i = Console.ReadLine();

            double a10 = StrBin2Dec(i);
            Console.WriteLine("Dla liczby binarnej {1} jej reprezentacja dziesiętna {0} ", a10, i);
        }


        static int[] Str2Int(string s)
        {

            int[] wynik;
            char[] temp = s.ToCharArray();
            int dl = temp.Length;
            wynik = new int[dl];

            for (int k = 0; k < dl; k++)
            {
                if (temp[dl - 1 - k] == '1')
                {
                    wynik[k] = 1;
                }
                else
                {
                    wynik[k] = 0;
                }
            }

            return wynik;
        }

        // funkcja oblicza wartość dowolnego wielomianu o współczynnikach całkowitych w dowolnym momencie
        static double Horner(int[] a, double x)
        {
            int n = a.Length - 1;
            double w = a[n];

            for (int k = n - 1; k >= 0; k--)
            {
                w = w * x + a[k];
            }

            return w;
        }

        static double Bin2Dec(int[] a)
        {
            return Horner(a, 2);
        }

        static double StrBin2Dec(string s)
        {
            return Bin2Dec(Str2Int(s));
        }
    }
}
