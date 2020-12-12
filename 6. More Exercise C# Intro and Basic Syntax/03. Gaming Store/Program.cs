using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            //Var
            double spent = 0; 

            //Input
            double balance = double.Parse(Console.ReadLine()); ;

            //Logic
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="Game Time")
                {
                    //Output
                    Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", spent,balance);
                    break;
                }
               
                switch (command)
                { 
                    case "OutFall 4":
                        if (balance>=39.99)
                        {
                            balance -= 39.99;
                            spent += 39.99;
                            Console.WriteLine("Bought OutFall 4"); 
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if (balance >= 15.99)
                        {
                            balance -= 15.99;
                            spent += 15.99;
                            Console.WriteLine("Bought CS: OG");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (balance >= 19.99)
                        {
                            balance -= 19.99;
                            spent += 19.99;
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (balance >= 59.99)
                        {
                            balance -= 59.99;
                            spent += 59.99;
                            Console.WriteLine("Bought Honored 2");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (balance >= 29.99)
                        {
                            balance -= 29.99;
                            spent += 29.99;
                            Console.WriteLine("Bought RoverWatch");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (balance >= 39.99)
                        {
                            balance -= 39.99;
                            spent += 39.99;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                        // The game is not found
                    default:
                        Console.WriteLine("Not Found");
                        break;

                }
                //Out of Money
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
            
        }
    }
}
