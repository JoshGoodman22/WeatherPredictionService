namespace WeatherPredictionService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GettingDate


    {

        static List<string> LoadData()
        {
            List<string> lines = System.IO.File.ReadAllLines("HistoricalWeatherDataLA.csv").ToList();
            Console.WriteLine("Okay..Data base is loading...");
               string header_line = lines[0]; // The first line just contains the headers
            Console.WriteLine($"Done! {lines.Count} dates loaded.");
            return lines;
        }


        /// <summary>
        /// This Static Void will prompt the user to give a correct date that will be validated. 
        /// </summary>
        /// <param name="args"></param>
        static void GetStarted(string[] args)

        {
            string UserMonth;
            string UserDay;

            Console.WriteLine("Hello, I am your weather Prediction service - Please enter a month as an integer 1-12 for the month for ex. 01 is January");
            UserMonth = Console.ReadLine();
            Console.WriteLine($"Okay awesome, this is month {UserMonth} of the year. Now please enter a day from that month as an integer 1-31 for ex. 23 id the 23rd");
            UserDay = Console.ReadLine();
            Console.WriteLine($"Okay awesome, you want to know the weather for the date {UserMonth}/{UserDay}");

            List<string> data = LoadData();

        }

        /// <summary>
        /// This method will ensure that the date given will work with and match with the WeatherPredictionData.csv
        /// </summary>
        /// <param name="Month"></param>
        static void ValidateGuess(string UserMonth, string UserDay)
        {
            int MonthNum;
            int DayNum;

            MonthNum = int.Parse(UserMonth);
            DayNum = int.Parse(UserDay);
            if (MonthNum > 13)
            {
                throw new Exception("The month you entered doesnt exist");

            }
            if (DayNum > 31)
            {
                throw new Exception("The Day you entered doesnt exist");
            }
            else
            {
                return;
            }
        }

        static string FilterDates()
        {
            return null;
        }

        /// <summary>
        /// This Method will use the temperatures From FilterDates() to create an average, mode, mean, and median. It will then display the information to the user
        /// </summary>
        static void CreatePrediction()
        {
            return;
        }


    }
}