using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            //var
            double expenses = 0.0;
            int brokenHeadset = 0;
            int brokenMouse = 0;
            int brokenKeyboard = 0;
            int brokenDisplay = 0;

            //Input
            int numberOfLostGames = int.Parse(Console.ReadLine());
            double priceHeadset = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());

            //Logic
            brokenHeadset = numberOfLostGames / 2;
            brokenMouse = numberOfLostGames / 3;
            brokenKeyboard = numberOfLostGames / 6;
            brokenDisplay = numberOfLostGames / 12;

            expenses = brokenDisplay*priceDisplay + brokenHeadset*priceHeadset + brokenKeyboard*priceKeyboard + brokenMouse*priceMouse;
            Console.WriteLine("Rage expenses: {0:f2} lv.",expenses);
        }
    }
}
