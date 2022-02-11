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
            string UserMonth;
            string UserDay;

            Console.WriteLine("Hello, I am your weather Prediction service - Please enter a month as an integer 1-12 for the month for ex. 01 is January");
            UserMonth = Console.ReadLine();
            Console.WriteLine($"Okay awesome, this is month {UserMonth} of the year. Now please enter a day from that month as an integer 1-31 for ex. 23 id the 23rd");
            UserDay = Console.ReadLine();
            Console.WriteLine($"Okay awesome, you want to know the weather for the date {UserMonth}/{UserDay}");

            List<string> data = LoadData("HistoricalWeatherDataLA.csv");
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
                return (MonthNum, DayNum);
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
            int MonthNum;
            if(int.TryParse(month, out MonthNum) == false || month.Length != 2 || MonthNum >= 13)
            {
                throw new Exception($" Cannot use invalid {month}");
            }
            
            int dayNum;
            if(int.TryParse(day, out dayNum) == false)
            {
                throw new Exception($"Cannot use invalid date {day}");
            }
            // List<string> first_line_data = data[1].Split(",").ToList();
            // string date = first_line_data[1]; 
            List<string> results = new List<string>();

            foreach(string line in data)
            {
                List<string> row = line.Split(",").ToList();
                string yearMonthDay = row[1];
                string rowMonth = yearMonthDay.Substring(5,2);
                string rowDay = yearMonthDay.Substring(8,2);

                if (rowDay==day && rowMonth==month)
                {
                    results.Add(line);
                }


            }
            return results;
        }


/// <summary>
/// This method will take the lines given by FilterDates and extract a list of temperatures from those dates that will then be used to calculate the Average, Mean, Median, Mode. 
/// It will take in the List string from FilterDates.
/// </summary>
/// <returns></returns>
        public static List<double> GetTemperatures(List<string> csvData)
        {
            List<double> totalDates = new List<double>();
            foreach (string line in csvData)
            {
                List<string> row = line.Split(",").ToList();
                double AvgTemp = double.Parse(row[6]);
                totalDates.Add(AvgTemp);
            }


            return totalDates;
        }

    

    /// <summary>
    /// This Method will use the temperatures From FilterDates() to create an average, mode, mean, and median. It will then display the information to the user
    /// This methos will take in and read the string of temperatures from GetTemperatures 
    /// </summary>
    public static void CreatePrediction()
    {
        return;
    }
/// <summary>
/// /// This will take in the list of doubles from get temperatures and perform simple math functions to get a mode. This will produce a double that wil shown in create prediction. 
/// </summary>
/// <param name="toAnalyze"></param>
/// <returns></returns>
    public static double GetMedian(List<double> toAnalyze)
    {
        return 0;
    }


/// <summary>
/// /// This will take in the list of doubles from get temperatures and perform simple math functions to get a median. This will produce a double that wil shown in create prediction. 
/// </summary>
/// <param name="toAnalyze"></param>
/// <returns></returns>
    public static double GetMode(List<double> toAnalyze)
    {
        return 0;
    }


/// <summary>
/// This will take in the list of doubles from get temperatures and perform simple math functions to get a mean. This will produce a double that wil shown in create prediction. 
/// </summary>
/// <param name="toAnalyze"></param>
/// <returns></returns>
    public static double GetMean(List<double> toAnalyze)
    {
      
        return 0; 
    }
      

}
}