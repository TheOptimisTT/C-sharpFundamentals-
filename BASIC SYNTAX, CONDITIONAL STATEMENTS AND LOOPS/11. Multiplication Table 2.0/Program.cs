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
            int times = int.Parse(Console.ReadLine());

            //Logic
            if (times<=10)
            {
                for (int i = times; i <= 10; i++)
                {
                    a = number * i;
                    Console.WriteLine("{0} X {1} = {2}", number, i, a);
                }
            }
            else
            {
                a = number * times;
                Console.WriteLine("{0} X {1} = {2}", number, times, a);
            }
           
        }
    }
}