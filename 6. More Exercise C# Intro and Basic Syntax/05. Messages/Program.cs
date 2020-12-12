using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            //var
            string two = "abc";
            string three = "def";
            string four = "ghi";
            string five = "jkl";
            string six = "mno";
            string seven = "pqrs";
            string eight = "tuv";
            string nine = "wxyz";
            string mаssage = "";

            //input
            int numberOfLetters = int.Parse(Console.ReadLine());

            //logic
            for (int i = 0; i < numberOfLetters; i++)
            {

                string input = Console.ReadLine();
                char current = input[0];
                switch (current)
                {
                    case '2':
                        massage += two[input.Length - 1];
                        break;
                    case '3':
                        massage += three[input.Length - 1];
                        break;
                    case '4':
                        massage += four[input.Length - 1];
                        break;
                    case '5':
                        massage += five[input.Length - 1];
                        break;
                    case '6':
                        massage += six[input.Length - 1];
                        break;
                    case '7':
                        massage += seven[input.Length - 1];
                        break;
                    case '8':
                        massage += eight[input.Length - 1];
                        break;
                    case '9':
                        massage += nine[input.Length - 1];
                        break;
                    case '0':
                        massage += " ";
                        break;
                }
            }

            //Output
            Console.WriteLine(massage);
        }
    }
}
