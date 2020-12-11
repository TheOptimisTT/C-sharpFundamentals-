using System;
using System.Globalization; // Need this for DateTime

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        //var
        var holidaysCount = 0;

        //input
        var startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture); //mm stands for minutes. M stands for date
        var endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture); // only 1 "d"  not 2

        //logic
        for (var date = startDate; date <= endDate; date = date.AddDays(1)) //date = date.addDays
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday) // not && but ||
            {
                holidaysCount++;
            }
        }
        Console.WriteLine(holidaysCount);

    }
}