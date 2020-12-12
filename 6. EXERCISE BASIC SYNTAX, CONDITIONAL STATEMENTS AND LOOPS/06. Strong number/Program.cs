using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            //var
            int sum = 0;
            string numString = "";

            //Input 145
            int number = int.Parse(Console.ReadLine());
            int realnumber = number;
            //Logic
            numString += number;
            for (int i = 0; i < numString.Length; i++)
            {
                int currentDigit=number%10;
                number = (number - currentDigit) / 10;
                int factoriel = 1;
                for (int i1 = 1; i1 <= currentDigit; i1++)
                {
                    factoriel *= i1;
                }
                sum += factoriel;
            }

            //Output
            if (sum==realnumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
