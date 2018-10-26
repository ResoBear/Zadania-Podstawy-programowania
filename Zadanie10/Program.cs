using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for(int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program pokazuje ciąg Fibonacciego do n liczb.");
            Console.WriteLine("Podal liczbę całkowitą, dodatnią n:");
            int a;
            a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Wynik:");
            for(int i = 0; i < a; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }
    }
}
