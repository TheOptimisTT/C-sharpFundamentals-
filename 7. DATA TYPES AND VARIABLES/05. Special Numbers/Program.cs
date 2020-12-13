using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int input = int.Parse(Console.ReadLine());

            //logic
            for (int i = 1; i <= input; i++)
            {
                if (i <= 9)
                {
                    if (i % 5 == 0 || i % 7 == 0|| i % 11 == 0)
                    {
                        Console.WriteLine("{0} -> True", i);
                    }
                    else
                    {
                        Console.WriteLine("{0} -> False", i);
                    }
                }
                else
                {
                    int lastNumber = i;
                    int sum = 0;
                    while (lastNumber > 0)
                    {
                        sum += lastNumber % 10;
                        lastNumber /= 10;
                    }
                    if (sum == 5 || sum == 7 || sum == 11)
                    {
                        Console.WriteLine("{0} -> True", i);
                    }
                    else
                    {
                        Console.WriteLine("{0} -> False", i);
                    }
                }

            }

        }
    }
}
