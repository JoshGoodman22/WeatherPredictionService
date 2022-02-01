using System;
using System.Collections.Generic;
using System.IO;

class TestLoadData
{
public static bool RunTest()
    {
        // Load Test CSV
        List<string> dates = WeatherPredictionService.GettingDate.LoadData("test.csv");

        // This file contains 5 entrys of lines 
        if (dates.Count != 5)
        {
            Console.Error.WriteLine(" The file test.csv should only have 5 lines but that is not the case... Error! " );
            return false;

        }

        // the first entry line should begin with a 9 digit number "283996800"
        if (dates[0] != "283996800")
        {
            Console.Error.WriteLine(" The first line of test.csv should begin with \"283996800\", this is not the case... Error! " );
            return false;

        }

        try
        {
            WeatherPredictionService.GettingDate.LoadData("NotAEntry.csv");
            Console.Error.WriteLine(" The file loaded in was incorrect...Expected an exception from loading \"NotAEntry.csv\" ... Error!");
        }
        catch (Exception e)
        {
            //Ignore 
        }

        return true;
    }
}