using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,i = 0;
            
            Console.WriteLine("Progam pokazuje z ilu cyfr składa się liczba.");
            Console.WriteLine("Podaj liczbę całkowitą: ");
            a = Convert.ToInt32(Console.ReadLine());

            while(true)
            {
                if(a > 0)
                {
                    a = a / 10;
                    i++;
                }
                else
                {
                    break;
                }
             
            }
            
            Console.WriteLine("Liczba {0} składa się z {1} cygr", a, i);

        }
    }
}
