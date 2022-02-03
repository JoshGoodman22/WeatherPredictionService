using System;
using System.Collections.Generic;
using System.IO;

namespace WeatherPredictionService
{
class TestFilterDates
{
    public static bool RunTest()
    {
        //public static List<string> FilterDates(List<string> data, string month, string day)

        List<string> testData = new List<string>();
        testData.Add("ignorethis,1979-01-05 00:00:00 +0000 UTC,ignorethis");
        testData.Add("ignorethis,2011-08-01 00:00:00 +0000 UTC,ignorethis");
        testData.Add("ignorethis,1999-12-01 00:00:00 +0000 UTC,ignorethis");
        testData.Add("ignorethis,1988-04-01 00:00:00 +0000 UTC,ignorethis");
        testData.Add("ignorethis,2020-04-08 00:00:00 +0000 UTC,ignorethis");
        testData.Add("ignorethis,2222-08-01 00:00:00 +0000 UTC,ignorethis");
        List<string> results = GettingDate.FilterDates(testData, "12", "01");
        if (results.Count != 1)
        {
            Console.Error.WriteLine(" There is an error...ERROR!");
            return false;

        }

        if (results[0] != "ignorethis,1999-12-01 00:00:00 +0000 UTC,ignorethis")
        {
            Console.Error.WriteLine("An error has occurred, test.cvs does not match");
            return false;
        }
        List<string> results2 = GettingDate.FilterDates(testData, "04", "01");

        try
        {
            GettingDate.FilterDates(testData, "4", "01");
            Console.Error.WriteLine(" An error was expected but it didn't happen");
            return false;
        }
        catch
        {
          // Ignore
        }

        try 
        {
            GettingDate.FilterDates(testData, "04", "01"); // TODO(jcollard 2022-02-03): Why is this an error? This should probalby just return a list with no data in it.
            Console.Error.WriteLine(" There is no error");
        }
        catch (Exception e)
        {
            // Ignore this 
        }

        // TODO(jcollard 2022-02-03): Add a test for 08-01.

        return true;

    }
}
}