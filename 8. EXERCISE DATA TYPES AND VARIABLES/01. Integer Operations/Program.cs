using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int forthNumber = int.Parse(Console.ReadLine());

            //Var
            Int64 sum = (firstNumber + secondNumber);
            sum /= thirdNumber;
            sum *= forthNumber;

            //Output
            Console.WriteLine(sum);
        }
    }
}
