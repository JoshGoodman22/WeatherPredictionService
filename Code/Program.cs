using System;

namespace WeatherPredictionService
{
    class Program
    {
        static void Main(string[] args)
        {
            string Month;
            string Day;

            Console.WriteLine("Hello, I am your weather Prediction service - Please enter a month as an integer 1-12 for the month");
            Month = Console.ReadLine();
            Console.WriteLine($"Okay awesome, this is month {Month} of the year. Now please enter a day from that month as an integer 1-31");
            Day = Console.ReadLine();
            Console.WriteLine($"Okay awesome, you want to know the weather for the date {Month}/{Day}");

        }
    }
}
