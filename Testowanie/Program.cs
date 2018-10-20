﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testowanie
{

    namespace _01.Decimal_to_Binary
    {
        class DecimalToBinary
        {
            static void Main(string[] args)
            {
                Console.Write("Decimal: ");
                int decimalNumber = int.Parse(Console.ReadLine());

                int remainder;
                string result = ("");
                while (decimalNumber > 0)
                {
                    remainder = decimalNumber % 2;
                    decimalNumber /= 2;
                    result = remainder.ToString() + result;
                }
                Console.WriteLine("Binary:  {0}", result);
            }
        }
    }
}
