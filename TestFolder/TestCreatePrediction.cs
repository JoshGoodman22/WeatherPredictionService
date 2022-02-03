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