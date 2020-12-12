using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            // var
            int a; //number of free belts
            double addLighsabers = 0; //10% more sabers 
            double costOfLighsabers = 0.0;
            double costOfBelts = 0.0;           
            double costOfRobes = 0.0;
            double costOverall = 0.0;

            //Input
            double money = double.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            double priceLightsaber = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());

            //Logic
            costOfLighsabers = numberOfStudents * priceLightsaber;
            addLighsabers = numberOfStudents * 0.1;
            addLighsabers = Math.Ceiling(addLighsabers);
            costOfLighsabers += priceLightsaber * addLighsabers;
           
            if (numberOfStudents>=6)
            {
                a = numberOfStudents / 6;
                costOfBelts = (priceBelt * numberOfStudents) - (priceBelt * a);
            }
            else
            {
                costOfBelts = (priceBelt * numberOfStudents);
            }

            costOfRobes = priceRobe * numberOfStudents;
            costOverall = costOfBelts + costOfLighsabers + costOfRobes;

            //Output
            if (money>=costOverall)
            {
                Console.WriteLine("The money is enough - it would cost {0:f2}lv.",costOverall);
            }
            else
            {
                Console.WriteLine("Ivan Cho will need {0:f2}lv more.",costOverall-money);
            }
        }
    }
}
