using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSSENWD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ilość przekazywanych argumentów w linii poleceń {0}", args.Length);

            for (int k = 0; k < args.Length; k++)
            {
                Console.WriteLine("Argument [{0}] jest równy {1}", k, args[k]);
            }

            int a = 345;
            int b = 27;
            int c = NWD(a, b);

            Console.WriteLine("NWD dla {0} i {1} jest równe {2}", a, b, c);
        }

        static int NWD(int a, int b)
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
