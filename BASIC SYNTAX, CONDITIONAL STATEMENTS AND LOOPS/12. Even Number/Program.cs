using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //var
            var a= 0;

            //Logic
            while (true)
            {
                //Input
                int number = int.Parse(Console.ReadLine());

                //Output if not even
                if (number % 2 != 0)
                {
                    
                    Console.WriteLine("Please write an even number.");
                }
                else
                {
                    a = number;
                    break;
                }
            }

            //Output
            Console.WriteLine("The number is: {0}",Math.Abs(a));
        }
    }
}
