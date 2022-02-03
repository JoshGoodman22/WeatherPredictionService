using System;
using System.Collections.Generic;
using System.IO;

namespace WeatherPredictionService
{
    class TestCreatePrediction
    {

        public static bool RunTest()
        {

            //This Method will use the temperatures From FilterDates() to create an average, mode, mean, and median. It will then display the information to the user
            // This methos will take in and read the string of temperatures from GetTemperatures 

            //(int UserDay, int UserMonth) = WeatherPredictionService.TestCreatePrediction("12", "12");
            
            List<string> testFilteredDates = new List<string>();
            testFilteredDates.Add("1607731200,2001-12-12 00:00:00 +0000 UTC,-28800,90274,33.779375,-118.352039,287.29,");
            testFilteredDates.Add("1607731200,2002-12-12 00:00:00 +0000 UTC,-28800,90274,33.779375,-118.352039,287.29,");
            testFilteredDates.Add("1607731200,2003-12-12 00:00:00 +0000 UTC,-28800,90274,33.779375,-118.352039,287.29,");
            testFilteredDates.Add("1607731200,2004-12-12 00:00:00 +0000 UTC,-28800,90274,33.779375,-118.352039,287.29,");
            testFilteredDates.Add("1607731200,2005-12-12 00:00:00 +0000 UTC,-28800,90274,33.779375,-118.352039,287.29,");
            testFilteredDates.Add("1607731200,2006-12-12 00:00:00 +0000 UTC,-28800,90274,33.779375,-118.352039,287.29,");
            List<string> totalDates = GettingDate.FilterDates(testFilteredDates, "12", "12"); // Im not sure abt this line. Am I taking in the filtered dates or am i exacting it. 

            if (totalDates.Count != 6);
            {
                Console.Error.WriteLine(" There is an unusual number in the returned list...ERROR");
                // It wont let me return false
                
            }
             if (totalDates[0] != "1607731200,2001-12-12 00:00:00 +0000 UTC,-28800,90274,33.779375,-118.352039,287.29,")
             {
                    Console.Error.WriteLine("There is an unexpected error that happened. Dates complied ");
                    return false;

             }
             return false;





        }
    }
}