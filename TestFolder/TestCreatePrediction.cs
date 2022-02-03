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
            
            List<string> AverageTemp = new List<string>();
            AverageTemp.Add("294 k");
            AverageTemp.Add("212 k");
            AverageTemp.Add("222 k");
            AverageTemp.Add("201 k");
            AverageTemp.Add("214 k");
            
            //List<string> Temperatures = List<string> AverageTemp;
    
           
            // I need to add test here in the morning because these test aren't done. Im just super confused on this one because I cant create different ints that need to be made. And I have tried this one so many times but for some reason I cant seem get something without a lof of erros. My gettingdate.Createprediction just doesnt work for me. 
            return false;






        }
    }
}