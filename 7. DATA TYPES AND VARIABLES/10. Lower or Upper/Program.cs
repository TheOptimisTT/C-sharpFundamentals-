using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            char input = char.Parse(Console.ReadLine());

            //Logic
            if (input >= 65 && input <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if (input >= 97 && input <= 122)
            {
                Console.WriteLine("lower-case");
            }


            //Using ASCII table ! http://www.asciitable.com/
        }
    }
}
