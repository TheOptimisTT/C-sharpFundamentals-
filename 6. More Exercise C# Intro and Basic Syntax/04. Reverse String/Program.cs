using System;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input

           string input = Console.ReadLine();

            //Logic
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
        }
    }
}
