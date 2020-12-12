using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants 
            double studentDiscount = 0.15;
            double regularDiscount = 0.05;

            //var
            double price = 0.0;

            //Input
            int groupNumber = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            //Logic
            if (dayOfWeek == "Friday")
            {
                if (typeOfGroup == "Students")
                {
                    price = groupNumber * 8.45;
                }
                else if (typeOfGroup == "Business")
                {
                    if (groupNumber >= 100)
                    {
                        groupNumber -= 10;
                    }
                    price = groupNumber * 10.9;
                }
                else if (typeOfGroup == "Regular")
                {
                    price = groupNumber * 15;
                }
            }
            else if (dayOfWeek == "Saturday")
            {
                if (typeOfGroup == "Students")
                {
                    price = groupNumber * 9.8;
                }
                else if (typeOfGroup == "Business")
                {
                    if (groupNumber >= 100)
                    {
                        groupNumber -= 10;
                    }
                    price = groupNumber * 15.6;
                }
                else if (typeOfGroup == "Regular")
                {
                    price = groupNumber * 20;
                }
            }
            else if (dayOfWeek == "Sunday")
            {
                if (typeOfGroup == "Students")
                {
                    price = groupNumber * 10.46;
                }
                else if (typeOfGroup == "Business")
                {

                    if (groupNumber >= 100)
                    {
                        groupNumber -= 10;
                    }
                    price = groupNumber * 16;

                }
                else if (typeOfGroup == "Regular")
                {
                    price = groupNumber * 22.5;
                }
            }

            //Discount adding
            if (groupNumber >= 30 && typeOfGroup == "Students")
            {
                price -= (price * studentDiscount);
            }
            if (groupNumber >= 10 && groupNumber <= 20 && typeOfGroup == "Regular")
            {
                price -= price * regularDiscount;
            }

            //OutPut
            Console.WriteLine("Total price: {0:f2}", price);
        }
    }
}
