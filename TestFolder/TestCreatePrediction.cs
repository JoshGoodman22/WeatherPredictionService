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

           // GettingDate.CreatePrediction();

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
            if (expected != mode)
            {
                Console.Error.WriteLine(" An error has occurred...This Mode is wrong");
                return false;
            }


            double median = GettingDate.GetMedian(testTemps);
            expected = 20;
            // What if the value does not return the correct math. 
            if (expected != median)
            {
                Console.Error.WriteLine(" An Error has occurred.. the Median is wrong");
                return false;
            }



            double mean = GettingDate.GetMean(testTemps);
            expected = 20;
            // What if the value does not return the correct math. 
            if (expected != mean)
            {
                Console.Error.WriteLine(" An Error has occurred.. the Average is wrong");
                return false;
            }


            // What if the inputted value is negative> 
            try
            {
                WeatherPredictionService.GettingDate.GetMean(FakeMean);
                Console.Error.WriteLine(" An expected error has occurred, the number cannot be negative");
                return false;
            }
            catch
            {
                // Ignore this
            }
            List<double> FakeMean2 = new List<double>(84);
            List<double> testTemps2 = new List<double>();
            testTemps.Add(70);
            testTemps.Add(91);
            testTemps.Add(81);
            testTemps.Add(95);
        

            // double mode2 = GettingDate.GetMode(testTemps);
            double expected2 = 84;

            if (expected2 != 84)
            {
                Console.Error.WriteLine(" There has been an error in the math and a incorrect number has been printed please try again");
                return false;

            }
            try
            {
                WeatherPredictionService.GettingDate.GetMean(FakeMean2);
                Console.Error.WriteLine("There is an error that was expected but did not occur");
                return false;
            }
            catch
            {
                // ignore 
            }





            // List<double> Negativeinput = new List<double>(-10);
            // Negativeinput = int.Parse(-10);
            // Negativeinput.Add(-10);


            // double input = GettingDate.GetMean(Negativeinput);
            // if (Negativeinput = -10)
            // {
            //         Console.Error.WriteLine("Cannot compute a Mean that included a negative number");
            //         return false;

            // }






            // TODO(jcollard 2022-02-08): Right now you are essentially only
            // testing that your methods only returns 20 What about a different
            // set of inputs that makes them return different values?
            // Keep the test case above but add a new one below.


            return true;






        }
    }
}