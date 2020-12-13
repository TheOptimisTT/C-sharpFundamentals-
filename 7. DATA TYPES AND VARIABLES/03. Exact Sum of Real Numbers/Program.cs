using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            int numberOfNumbers = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfNumbers; i++)
            {
                decimal number1 = decimal.Parse(Console.ReadLine());
                sum += number1;
            }
            Console.WriteLine(sum);
        }
    }
}
