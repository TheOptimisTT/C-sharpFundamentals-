using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            //const
            string nuts = "Nuts"; double nutsPrice = 2.0;
            string water = "Water"; double waterPrice = 0.7;
            string crisps = "Crisps"; double crispsPrice = 1.5;
            string soda = "Soda"; double sodaPrice = 0.8;
            string coke = "Coke"; double cokePrice = 1;

            //var
            double money = 0;

            //Logic coin collection
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Start")
                {
                    break;
                }
                double insertedCoins = double.Parse(command);
                //Type of coins0.1, 0.2, 0.5, 1, and 2 
                if (insertedCoins == 0.1 || insertedCoins == 0.2 || insertedCoins == 0.5 || insertedCoins == 1 || insertedCoins == 2)
                {
                    money += insertedCoins;
                }
                else
                {
                    Console.WriteLine("Cannot accept {0}", insertedCoins);
                }
            }

            //Logic Purchasing goods 
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    Console.WriteLine("Change: {0:f2}",money);
                    break;

                }
                if (command == nuts)
                {
                    if (money >=nutsPrice)
                    {
                        Console.WriteLine("Purchased nuts");
                        money -= nutsPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command==water)
                {
                    if (money >= waterPrice)
                    {
                        Console.WriteLine("Purchased water");
                        money -= waterPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == crisps)
                {
                    if (money >= crispsPrice)
                    {
                        Console.WriteLine("Purchased crisps");
                        money -= crispsPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == soda)
                {
                    if (money >= sodaPrice)
                    {
                        Console.WriteLine("Purchased soda");
                        money -= sodaPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == coke)
                {
                    if (money >= cokePrice)
                    {
                        Console.WriteLine("Purchased coke");
                        money -= cokePrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

            }
        }
    }
}
