using System;

namespace Passed_or_Failed
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double grade = double.Parse(Console.ReadLine());
            //logic
            if (grade>=3)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
