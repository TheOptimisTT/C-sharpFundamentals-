using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int number = int.Parse(Console.ReadLine());

            //var
            int sum = 0;
            
            //logic
            for (int i = 1; i <= number; i++)
            {
                int currentNumber = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", currentNumber, isSpecial);
                sum = 0;
                i = currentNumber;
            }

        }
    }
}
