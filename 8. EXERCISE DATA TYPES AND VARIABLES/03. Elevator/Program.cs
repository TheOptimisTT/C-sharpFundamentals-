using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());

            //var
            double coursesNeeded = (double)numberOfPeople / capacityOfElevator;

            //Output
            Console.WriteLine(Math.Ceiling(coursesNeeded));
        }
    }
}
