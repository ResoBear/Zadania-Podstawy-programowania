using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10_1
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
            Console.WriteLine("Program pokaże ciąg Fibonaciego mniejszy od n liczby.");
            Console.WriteLine("Podaj liczbę cłkowitą dodatnią n: ");
            int n;

            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wynik:");
            for(int i = 0; i < n; i++)
            {
                if (Fibonacci(i) > n)
                {
                    break;
                }
                Console.WriteLine(Fibonacci(i));
               
            }


        }
    }
}
