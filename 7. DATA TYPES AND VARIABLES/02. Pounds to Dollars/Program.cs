﻿using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal GBP = decimal.Parse(Console.ReadLine());
            decimal USD = GBP * (decimal)1.31;
           
            Console.WriteLine("{0:f3}",USD);
        }
    }
}
