using System;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2021, 1, 1);
            var now = DateTime.Now; //now date
            var today = DateTime.Today; //today's date
            
            Console.WriteLine($"Hour: {now.Hour}"); //Hour at the start of the program
            Console.WriteLine($"Minute {now.Minute}"); //Minute at the start of the program

            var tomorrow = now.AddDays(1);   //tommorow's date
            var yesterday = now.AddDays(-1); //yesterday's date
            
            
            Console.WriteLine(now.ToLongDateString());  //long date
            Console.WriteLine(now.ToShortDateString()); //short date
            Console.WriteLine(now.ToLongTimeString());  //long time
            Console.WriteLine(now.ToShortTimeString()); //short time
            Console.WriteLine(now.ToString("D")); //long date
        }
    }
}
