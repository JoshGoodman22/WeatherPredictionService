namespace WeatherPredictionService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GettingDate


    {

        /// <summary>
        /// Load(Data) will generate the data from the CSV and create a string of dates. It will also show the user that how many dates have been loaded. 
        /// </summary>
        /// <returns></returns>
        public static List<string> LoadData(string filename)
        {
            List<string> lines = System.IO.File.ReadAllLines("HistoricalWeatherDataLA.csv").ToList();
            Console.WriteLine("Okay..Data base is loading...");
            Console.WriteLine($"Done! {lines.Count} dates loaded.");
            return lines;
        }

        internal static List<string> GetTemperatures(int v)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// This method will prompt the user to enter a date.  This is the entry point. 
        /// </summary>
        /// <param name="args"></param>
       public static (int, int) GetStarted()
        {
            //string UserMonth;
            //string UserDay;

            //Console.WriteLine("Hello, I am your weather Prediction service - Please enter a month as an integer 1-12 for the month for ex. 01 is January");
            //UserMonth = Console.ReadLine();
            //Console.WriteLine($"Okay awesome, this is month {UserMonth} of the year. Now please enter a day from that month as an integer 1-31 for ex. 23 id the 23rd");
            //UserDay = Console.ReadLine();
            //Console.WriteLine($"Okay awesome, you want to know the weather for the date {UserMonth}/{UserDay}");

            //List<string> data = LoadData();
            return (0,0);

        }

        /// <summary>    
        /// "Given the users string input for month and day, checks to make sure it is a valid date. If it is not, an exception is thrown.
        ///  Otherwise, returns the month and day as int values"
        /// </summary>
        /// <param name="UserMonth">UserMonth is the Month the user entered and must be real</param>
        /// <param name="UserDay">UserDay is the day the user entered and must be real </param>
        public static (int MonthNum, int DayNum) ValidateDate(string UserMonth, string UserDay)
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
                return (9, 14);
            }
        }

        /// <summary>
        /// This Method will will filter and match the UserMonth and UserDay to the dates from the CVS. It will return a string of dates that matched the users dates.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static List<string> FilterDates(List<string> data, string month, string day)
        {
            foreach(string line in data)
            {
                List<string> row = line.Split(",").ToList();
                
                

            }
            return null;
        }


/// <summary>
/// This method will take the lines given by FilterDates and extract a list of temperatures from those dates that will then be used to calculate the Average, Mean, Median, Mode. 
/// It will take in the List string from FilterDates.
/// </summary>
/// <returns></returns>
        public static List<double> GetTemperatures(List<string> averageTemp)
        {
            double temp = 4.7;
            return null;
        }

    

    /// <summary>
    /// This Method will use the temperatures From FilterDates() to create an average, mode, mean, and median. It will then display the information to the user
    /// This methos will take in and read the string of temperatures from GetTemperatures 
    /// </summary>
    public static void CreatePrediction()
    {
        return;
    }

    public static double GetMedian(List<double> toAnalyze)
    {
        return 0;
    }

    public static double GetMode(List<double> toAnalyze)
    {
        return 0;
    }

    public static double GetMean(List<double> toAnalyze)
    {
        return 0; 
    }
        // create other methods for other predictions

}
}