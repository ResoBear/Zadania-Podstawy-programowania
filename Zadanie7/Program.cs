using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            //wprowadzenie danych
            Console.WriteLine("Program przekonwertuje liczbę dodatnią całkowitą na postać szesnastkową.\n");
            Console.WriteLine("Podaj liczbę: ");
            long decNumber = long.Parse(Console.ReadLine());

            string hexNumber = "";
            
            //pętla
            while (decNumber != 0)
            {
                long remain = decNumber % 16;

                //wybur odpowiedniej sekcji
                switch (remain)
                {
                    case 10:
                        hexNumber = "A" + hexNumber;
                        break;
                    case 11:
                        hexNumber = "B" + hexNumber;
                        break;
                    case 12:
                        hexNumber = "C" + hexNumber;
                        break;
                    case 13:
                        hexNumber = "D" + hexNumber;
                        break;
                    case 14:
                        hexNumber = "E" + hexNumber;
                        break;
                    case 15:
                        hexNumber = "F" + hexNumber;
                        break;
                    default:
                        hexNumber = remain + hexNumber;
                        break;
                }
                decNumber /= 16;
            }

            //wynik
            Console.WriteLine("Wynik = " + hexNumber);
        }
    }
}
