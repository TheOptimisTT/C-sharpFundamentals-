using System;

namespace Student_information
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            //output
            Console.WriteLine("Name: {0}, Age: {1}, Grade: {2:f2}",name,age,grade);
        }
    }
}
