using System;

namespace WeatherPredictionService
{
    class Program
    {
/// <summary>
/// 
/// </summary>
/// <param name="args"></param>
        static void Main(string[] args)
        {
            if(args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return; 
            }
            
            // GettingDate.GetStarted(args);
            
            // WeatherData.Program2.Main2();
            // string Month;
            // string Day;

            // Console.WriteLine("Hello, I am your weather Prediction service - Please enter a month as an integer 1-12 for the month for ex. 01 is January");
            // Month = Console.ReadLine();
            // Console.WriteLine($"Okay awesome, this is month {Month} of the year. Now please enter a day from that month as an integer 1-31 for ex. 23 id the 23rd");
            // Day = Console.ReadLine();
            // Console.WriteLine($"Okay awesome, you want to know the weather for the date {Month}/{Day}");

        }

        internal static object LoadFile(string v)
        {
            throw new NotImplementedException();
        }

        public static void TestAll()
        {
            bool testValidateDate = TestValidateDate.RunTest();
            Console.WriteLine($" Test ValidateData(UserDate); {testValidateDate}");

            // bool testLoadData = TestLoadData.RunTest();
            // Console.WriteLine($" Test LoadData(filename); {testLoadData}");

            

            bool testFilterDates = TestFilterDates.RunTest();
            Console.WriteLine($" Test FilterDates(Dates)); {testFilterDates}");

            // bool testGetStarted = TestGetStarted.RunTest();
            // Console.WriteLine($" Test GetStarted (CollectDate); {testValidateDate}");

             bool testGetTemperatures = TestGetTemperatures.RunTest();
             Console.WriteLine($" Test GetTemperatures(Temperatures); {testGetTemperatures}");

            // bool testCreatePrediction = TestCreatePrediction.RunTest();
            // Console.WriteLine($" Test CreatePredictions (Predictions) ; {testCreatePrediction}");

        

        }
    }
}
