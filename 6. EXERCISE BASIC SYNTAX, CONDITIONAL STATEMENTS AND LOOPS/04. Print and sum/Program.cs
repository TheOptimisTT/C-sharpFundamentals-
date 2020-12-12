using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Var
            int sum = 0;

            //Input
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            //Logic
            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.Write("{0} ",i);
                sum += i;
            }

            //Output
            Console.WriteLine("");
            Console.WriteLine("Sum: {0}",sum);
        }
    }
}
