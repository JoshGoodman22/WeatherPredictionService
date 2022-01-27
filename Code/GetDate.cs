namespace WeatherPredictionService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GettingDate


    {

        // TODO(jcollard: 2022-01-27): Add documentation comment
        static List<string> LoadData()
        {
            List<string> lines = System.IO.File.ReadAllLines("HistoricalWeatherDataLA.csv").ToList();
            Console.WriteLine("Okay..Data base is loading...");

            //TODO: You don't need the line below. This was just an example
               string header_line = lines[0]; // The first line just contains the headers

            
            Console.WriteLine($"Done! {lines.Count} dates loaded.");
            return lines;
        }


        // Feedback(jcollard: 2022-01-27): I am not 100% sure what you mean with
        // the comment below / what this method is trying to do. But, this method appears
        // to be your programs Entry Point. Is that correct?

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
        /// TODO(jcollard: 2022-01-27): With comments, try to use the following format:
        ///     "Given {variable-name} and {variable-name}, describe the action being performed. Then, returns {describe return-type}"
        ///     
        ///     In this case, the comment should be similar to this:
        ///     "Given the users string input for month and day, checks to make
        ///     sure it is a valid date. If it is not, an exception is thrown.
        ///     Otherwise, returns the month and day as int values"
        /// 
        /// </summary>
        /// <param name="UserMonth">TODO(jcollard: 2022-01-27): Write a parameter description</param>
        /// <param name="UserDay">TODO(jcollard: 2022-01-27): Write a parameter description</param>
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
                // TODO(jcollard: 2022-01-27): You probably want to return (MonthNum, DayNum)
                // The return type for this would be (int, int)
                return;
            }
        }

        //TODO(jcollard: 2022-01-27): Add comment
        static string FilterDates()
        {
            //TODO(jcollard: 2022-01-27): 
            // 1. Add step by step list
            // 2. I believe that you want to change the return type of this method to List<string> as it will be 
            // returning the specific lines from the CSV that meet the criteria
            // 3. I believe that you want to make the input to this method a List<string> which will be *all* the lines from
            // loading the database.
            return null;
        }

        /// <summary>
        /// This Method will use the temperatures From FilterDates() to create an average, mode, mean, and median. It will then display the information to the user
        /// </summary>
        static void CreatePrediction()
        {
            // TODO(jcollard: 2022-01-27): What inputs will you need to calculate the average, mode, mean, and median?
            // You probably will need a List<string> this list will probably be the result of FilterDates
            return;
        }


    }
}