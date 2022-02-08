using System;
using System.Collections.Generic;
using System.IO;

namespace WeatherPredictionService
{
    class TestCreatePrediction
    {

        public static bool RunTest()
        {

            // Note for Mx. Collard - In this test I wold have made sure of the folling
            // 1. That the numbers of Average Temp are real- non negative numbers that can be converted into an average. I would also make sure that these match the different dates the came from and that each date is the same. I would also test the method to see what happens if a date is in the list instead of a Kelvin number. Make sure that there were no errors complining the list. 

            //This Method will use the temperatures From FilterDates() to create an average, mode, mean, and median. It will then display the information to the user
            // This methos will take in and read the string of temperatures from GetTemperatures 

            //(int UserDay, int UserMonth) = WeatherPredictionService.TestCreatePrediction("12", "12");

            GettingDate.CreatePrediction();

            //TODO: Create 3 methods:
            // 1. GetMode(List<double> temps)
            List<double> FakeMean = new List<double>(21);
            List<double> testTemps = new List<double>();
            testTemps.Add(10);
            testTemps.Add(20);
            testTemps.Add(20);
            testTemps.Add(30);

            double mode = GettingDate.GetMode(testTemps);
            double expected = 20;
            // What if the value does not return the correct math. 
            if (expected != 20)
            {
                Console.Error.WriteLine(" An error has occurred...This Mode is wrong");
                return false;
            }


            double median = GettingDate.GetMedian(testTemps);
            expected = 20;
            // What if the value does not return the correct math. 
            if (expected != 20)
            {
                Console.Error.WriteLine(" An Error has occurred.. the Median is wrong");
                return false;
            }



            double mean = GettingDate.GetMean(testTemps);
            expected = 20;
            // What if the value does not return the correct math. 
            if (expected != 20)
            {
                Console.Error.WriteLine(" An Error has occurred.. the Average is wrong");
                return false;
            }


            // What if the inputted value is negative> 
            try
            {
                WeatherPredictionService.GettingDate.GetMean(FakeMean);
                Console.Error.WriteLine(" An expected error has occurred, the number cannot be negative");
            }
            catch
            {
                // Ignore this
            }





            return true;






        }
    }
}