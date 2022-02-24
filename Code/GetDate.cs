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
        public static (string, string) GetStarted()
        {
            string UserMonth;
            string UserDay;

            Console.WriteLine("Hello, I am your weather Prediction service - Please enter a month as an integer 1-12 for the month for ex. 01 is January");
            UserMonth = Console.ReadLine();
            Console.WriteLine($"Okay awesome, this is month {UserMonth} of the year. Now please enter a day from that month as an integer 1-31 for ex. 23 id the 23rd");
            UserDay = Console.ReadLine();
            Console.WriteLine($"Okay awesome, you want to know the weather for the date {UserMonth}/{UserDay}");

            return (UserMonth, UserDay);

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
            if (int.TryParse(month, out MonthNum) == false || month.Length != 2 || MonthNum >= 13)
            {
                throw new Exception($" Cannot use invalid {month}");
            }

            int dayNum;
            if (int.TryParse(day, out dayNum) == false)
            {
                throw new Exception($"Cannot use invalid date {day}");
            }
            // List<string> first_line_data = data[1].Split(",").ToList();
            // string date = first_line_data[1]; 
            List<string> results = new List<string>();

            foreach (string line in data)
            {
                try {
                    List<string> row = line.Split(",").ToList();
                    string yearMonthDay = row[1];
                    int rowYear = int.Parse(yearMonthDay.Substring(0,4));
                    string rowMonth = yearMonthDay.Substring(5, 2);
                    string rowDay = yearMonthDay.Substring(8, 2);

                    if (rowDay == day && rowMonth == month && rowYear > 2000)
                    {
                        results.Add(line);
                    }
                } catch {}


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
        public static void CreatePrediction(string filename, string Usermonth, string Userday)
        {
            List<string> csvData = LoadData("HistoricalWeatherDataLA.csv"); // Loading in the data
            (int validMonth, int validDay) = ValidateDate(Usermonth, Userday); // Validating the date and getting ints to be put into FilerDates 
            List<string> FilteredData = FilterDates(csvData, Usermonth, Userday); // Filtering data in CSV 
            List<double> FinalTemps = GetTemperatures(FilteredData); // 
            double median = KtoF(GetMedian(FinalTemps));
            double mode = KtoF(GetMode(FinalTemps));
            double mean = KtoF(GetMean(FinalTemps));
            Console.WriteLine($" Calculation COMPLETE!!!! On the Date {Usermonth},{Userday} it has historically been {mean} degrees. It is most often {mode} degrees. Fun fact! In the middle 1900s it was most commonly {median}");
            return;
        }

        public static double KtoF(double k) 
        { 
          var fahrenheit = ((k-273.15) * 9) / 5 + 32;

        
            return fahrenheit;
        }
        /// <summary>
        /// /// This will take in the list of doubles from get temperatures and perform simple math functions to get a mode. This will produce a double that wil shown in create prediction. 
        /// </summary>
        /// <param name="toAnalyze"></param>
        /// <returns></returns>
        public static double GetMedian(List<double> toAnalyze)
        {
            toAnalyze.Sort();
            int mid = toAnalyze.Count / 2;
            return toAnalyze[mid];
        }


        /// <summary>
        /// /// This will take in the list of doubles from get temperatures and perform simple math functions to get a median. This will produce a double that wil shown in create prediction. 
        /// </summary>
        /// <param name="toAnalyze"></param>
        /// <returns></returns>
        public static double GetMode(List<double> toAnalyze)
        {

            toAnalyze.Sort();
            double candidateMode = toAnalyze[0]; // The value we are currently counting
            int candidateCount = 0; // Tracks the number of times we have seen "candidateMode"
            double finalMode = toAnalyze[0]; // The value we have seen the most times so far (at the end this will be the mode we return)
            int finalCount = 0; // The count for finalMode

            // 3. We iterate through the elements of the list and count the values:
            foreach (double tempToCheck in toAnalyze) // Loopin
            {

                // 4. We check to see if the tempToCheck is the same value as the candidateMode.
                //    If it is, we need to increment candidateCount
                if (tempToCheck == candidateMode)
                {
                    candidateCount++;
                }
                else
                {
                    candidateMode = tempToCheck;
                    candidateCount = 1;
                }


                if (candidateCount > finalCount)
                {
                    finalCount = candidateCount;
                    finalMode = candidateMode;
                }

                // 5. ELSE that means we have finished counting all of the
                //    values that are equal to candidateMode
                // 5a. We need to check to see if the candidate was counted more times than the current finalMode
                // 5b. If it was, we update finalMode and finalCount
                // 5c. Then, we **always** (no else) set the candidateMode to be the tempToCheck and we reset candidateCount to 1 (since we have seen the new value once)

            }

            // 6. Finally, when we have finished iterating through all of the values, we know that finalMode is the mode of the list
            return finalMode;
        }


        /// <summary>
        /// This will take in the list of doubles from get temperatures and perform simple math functions to get a mean. This will produce a double that wil shown in create prediction. 
        /// </summary>
        /// <param name="toAnalyze"></param>
        /// <returns></returns>
        public static double GetMean(List<double> toAnalyze)
        {
            List<double> Mean = new List<double>();
            double allTemps = 0;
            foreach (double temp in toAnalyze) // Loopin
            {
                allTemps = temp + allTemps;


            }

            return allTemps / toAnalyze.Count;
        }


    }
}