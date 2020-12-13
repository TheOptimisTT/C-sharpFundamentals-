using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number = int.Parse(Console.ReadLine());

            while (number>0)
            {
                sum += number % 10;
                number /= 10;

            }
            Console.WriteLine(sum);
        }
    }
}
