using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int number = int.Parse(Console.ReadLine());

            //Logic
            for (int i = 1; i <= number; i++)
            {
                for (int i1 = 0; i1 < i; i1++)
                {
                    Console.Write("{0} ",i) ;
                }
                Console.WriteLine();
            }
        }
    }
}
