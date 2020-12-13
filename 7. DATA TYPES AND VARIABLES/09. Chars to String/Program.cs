using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());
            
            //var           
            string combined = firstChar.ToString()+secondChar.ToString()+thirdChar.ToString();

            //output
            Console.WriteLine(combined);
        }
    }
}
