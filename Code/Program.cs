using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherPredictionService
{



    class Program
    {
        static void Main()
        {
            (string month, string day) = GettingDate.GetStarted(); // getting user input 

            GettingDate.CreatePrediction("HistoricalWeatherDataLA.csv", month, day);
            // LoadData(string filename);
            // GettingDate.GetStarted();
            // ValidateDate();
            // FilterDates( List<string> data, string month, string day);
            // ValidateDate(string UserMonth, string UserDay)

           
            
            
        }

        public static (string, string) GetStarted()
            {
                string UserMonth;
                string UserDay;

                Console.WriteLine("Hello, I am your weather Prediction service - Please enter a month as an integer 1-12 for the month for ex. 01 is January");
                UserMonth = Console.ReadLine();
                Console.WriteLine($"Okay awesome, this is month {UserMonth} of the year. Now please enter a day from that month as an integer 1-31 for ex. 23 id the 23rd");
                UserDay = Console.ReadLine();
                Console.WriteLine($"Okay awesome, you want to know the weather for the date {UserMonth}/{UserDay}");

                List<string> data = LoadData("HistoricalWeatherDataLA.csv");
                return (UserMonth, UserDay);
            }
            public static List<string> LoadData(string filename)
            {
                List<string> lines = System.IO.File.ReadAllLines("HistoricalWeatherDataLA.csv").ToList();
                Console.WriteLine("Okay..Data base is loading...");
                Console.WriteLine($"Done! {lines.Count} dates loaded.");
                return lines;
            }


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
                    List<string> row = line.Split(",").ToList();
                    string yearMonthDay = row[1];
                    string rowMonth = yearMonthDay.Substring(5, 2);
                    string rowDay = yearMonthDay.Substring(8, 2);

                    if (rowDay == day && rowMonth == month)
                    {
                        results.Add(line);
                    }


                }
                return results;
            }


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
    }
}

//         static void Main(string[] args)
//         {
//             if(args.Length > 0 && args[0] == "test")
//             {
//                 TestAll();
//                 return; 
//             }



//             // GettingDate.GetStarted(args);

//             // WeatherData.Program2.Main2();
//             // string Month;
//             // string Day;

//             // Console.WriteLine("Hello, I am your weather Prediction service - Please enter a month as an integer 1-12 for the month for ex. 01 is January");
//             // Month = Console.ReadLine();
//             // Console.WriteLine($"Okay awesome, this is month {Month} of the year. Now please enter a day from that month as an integer 1-31 for ex. 23 id the 23rd");
//             // Day = Console.ReadLine();
//             // Console.WriteLine($"Okay awesome, you want to know the weather for the date {Month}/{Day}");


//         }

//         internal static object LoadFile(string v)
//         {
//             throw new NotImplementedException();
//         }

//         public static void TestAll()
//         {
//             bool testValidateDate = TestValidateDate.RunTest();
//             Console.WriteLine($" Test ValidateData(UserDate); {testValidateDate}");

//             // bool testLoadData = TestLoadData.RunTest();
//             // Console.WriteLine($" Test LoadData(filename); {testLoadData}");



//             bool testFilterDates = TestFilterDates.RunTest();
//             Console.WriteLine($" Test FilterDates(Dates)); {testFilterDates}");

//             // bool testGetStarted = TestGetStarted.RunTest();
//             // Console.WriteLine($" Test GetStarted (CollectDate); {testValidateDate}");

//              bool testGetTemperatures = TestGetTemperatures.RunTest();
//              Console.WriteLine($" Test GetTemperatures(Temperatures); {testGetTemperatures}");

//             // bool testCreatePrediction = TestCreatePrediction.RunTest();
//             // Console.WriteLine($" Test CreatePredictions (Predictions) ; {testCreatePrediction}");



//         }
//     }

