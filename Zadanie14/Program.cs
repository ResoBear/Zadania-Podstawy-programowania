using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program przekonwertóje Twój tekst na tekst skladający się z dużych liter.");

            Console.WriteLine("Napisz coś:");
            string tek;
            tek = Convert.ToString(Console.ReadLine());

            string con = tek.ToUpper();

            Console.WriteLine("Tekst przed zmianą: {0}\n\nPo zmianie: {1}", tek, con);
        }
    }
}
