﻿using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            //output
            Console.WriteLine("{0}{1}{2}",firstName,delimiter,lastName);
        }
    }
}
