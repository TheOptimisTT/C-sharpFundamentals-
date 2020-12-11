using System;

namespace Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double grade = double.Parse(Console.ReadLine());

            //logic
            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
