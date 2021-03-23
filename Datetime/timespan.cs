using System;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {   
            // hard to understand if its hours, minutes, seconds etc.
            var timeSpan = new TimeSpan(1, 2, 3);
            
            // easy to understand
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);
            
            // Properties
            Console.WriteLine($"Minutes: {timeSpan.Minutes}");
            Console.WriteLine($"Total Minutes: {timeSpan.TotalMinutes}");
            
            // Add
            Console.WriteLine($"Add example: {timeSpan.Add(TimeSpan.FromMinutes(8))}");
            
            // Subtract
            Console.WriteLine($"Subtract example: {timeSpan.Subtract(TimeSpan.FromMinutes(8))}");
            
            // ToString
            Console.WriteLine($"ToString {timeSpan.ToString()}");
            
            // Parse
            Console.WriteLine($"Parse: {TimeSpan.Parse("01:02:03")}");
            
            // To not close program automatically
            Console.ReadLine();
        }
    }
}
