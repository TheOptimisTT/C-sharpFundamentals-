using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Var
            int sumOfTheASCIInumbers = 0;

            //Input
            int numberOfLines = int.Parse(Console.ReadLine());

            //Logic
            for (int i = 0; i < numberOfLines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sumOfTheASCIInumbers += letter;
            }

            //Output
            Console.WriteLine("The sum equals: {0}",sumOfTheASCIInumbers);
        }
    }
}
