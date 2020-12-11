using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Var
            int c = 1;
            int sum = 0;

            //Input
            int number = int.Parse(Console.ReadLine());

            //Logic
            for (int i = 1; i <= number; i++)
            {
                c = (i * 2) - 1;
                Console.WriteLine(c);
                sum += c;        
            }

            //Output
            Console.WriteLine("Sum: {0}",sum);
        }
    }
}
