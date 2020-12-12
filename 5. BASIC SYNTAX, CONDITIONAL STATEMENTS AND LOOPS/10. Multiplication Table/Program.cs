using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //var
            int a = 0;

            //input
            int number = int.Parse(Console.ReadLine());

            //Logic
            for (int i = 1; i <= 10; i++)
            {
                a = number * i;
                Console.WriteLine("{0} X {1} = {2}", number, i, a);
            }
        }
    }
}
