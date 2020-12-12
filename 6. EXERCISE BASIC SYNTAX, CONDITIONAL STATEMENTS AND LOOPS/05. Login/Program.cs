using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            //Var
            string password = string.Empty;
            int numberOfAttempts = 0;

            //Input
            string username = Console.ReadLine();

            //Password
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            //Logic
            while (true)
            {
                numberOfAttempts++;
                string passwordInput = Console.ReadLine();
                if (passwordInput == password)
                {
                    Console.WriteLine("User {0} logged in.", username);
                    break;
                }
                else if (numberOfAttempts < 4)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else if (numberOfAttempts >= 4)
                {
                    Console.WriteLine("User {0} blocked!", username);
                    break;
                }
            }
        }
    }
}
