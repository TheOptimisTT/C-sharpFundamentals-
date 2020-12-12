using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int age = int.Parse(Console.ReadLine());

            //Conditions
            bool con1 = age >= 0 && age <= 2;
            bool con2 = age > 2 && age <= 13;
            bool con3 = age > 13 && age <= 19;
            bool con4 = age > 19 && age <= 65;
            bool con5 = age >= 66;

            //Logic
            if (con1)
            {
                Console.WriteLine("baby");
            }
            else if (con2)
            {
                Console.WriteLine("child");
            }
            else if (con3)
            {
                Console.WriteLine("teenager");
            }
            else if (con4)
            {
                Console.WriteLine("adult");
            }
            else if (con5)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
