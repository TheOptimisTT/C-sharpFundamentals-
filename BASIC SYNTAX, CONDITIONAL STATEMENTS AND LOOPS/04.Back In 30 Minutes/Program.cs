using System;

namespace Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //const
            int waitingTime = 30;

            //input
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            //logic
            int sum = (hour * 60) + minutes + waitingTime;
            int printHour = sum / 60;
            int printMinute = sum - (printHour * 60);
            if (printMinute > 59)
            {
                printMinute -= 60;
                printHour++;
            }
            if (printHour > 23)
            {
                printHour -= 24;
            }
            //Output
            Console.WriteLine("{0}:{1:D2}", printHour, printMinute);

        }
    }
}
