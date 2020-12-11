using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            //bools
            var conditionAge1 = age >= 0 && age <= 18;
            var conditionAge2 = age > 18 && age <= 64;
            var conditionAge3 = age > 64 && age <= 122;

            var conditionDAY1 = day == "Weekday";
            var conditionDAY2 = day == "Weekend";
            var conditionDAY3 = day == "Holiday";

            //logic
            if (conditionAge1)
            {
                if (conditionDAY1)
                {
                    Console.WriteLine("12$");
                }
                if (conditionDAY2)
                {
                    Console.WriteLine("15$");
                }
                if (conditionDAY3)
                {
                    Console.WriteLine("5$");
                }
            }
            else if (conditionAge2)
            {
                if (conditionDAY1)
                {
                    Console.WriteLine("18$");
                }
                if (conditionDAY2)
                {
                    Console.WriteLine("20$");
                }
                if (conditionDAY3)
                {
                    Console.WriteLine("12$");
                }
            }
            else if (conditionAge3)
            {
                if (conditionDAY1)
                {
                    Console.WriteLine("12$");
                }
                if (conditionDAY2)
                {
                    Console.WriteLine("15$");
                }
                if (conditionDAY3)
                {
                    Console.WriteLine("10$");
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
