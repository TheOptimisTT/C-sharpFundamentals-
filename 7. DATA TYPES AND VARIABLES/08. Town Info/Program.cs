using System;

namespace _08._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string townName = Console.ReadLine();
            uint population = uint.Parse(Console.ReadLine());
            uint area = uint.Parse(Console.ReadLine());

            //output
            Console.WriteLine("Town {0} has population of {1} and area {2} square km.",townName,population,area);
        }
    }
}
