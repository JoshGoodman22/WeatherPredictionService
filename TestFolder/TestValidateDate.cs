using System;
using System.IO;

// TODO: Add namespace
class TestValidateDate
{
    public static bool RunTest()
    {
        // TODO(jcollard 2022-02-01): Think about different ways you might call ValidateDate
        // public static (int MonthNum, int DayNum) ValidateDate(string UserMonth, string UserDay)
        // 1. What happens if you pass the arguments "9", "14"? What should the return type be?

        (int resultNum, int resultDay) = WeatherPredictionService.GettingDate.ValidateDate("9", "14");
        if (resultNum != 9 || resultDay != 14)
        {
            Console.Error.WriteLine(" The date entered are not correct");

            return false;
        }

        (int resultMonthNum, int resultDayNum) = WeatherPredictionService.GettingDate.ValidateDate("7", "6");
        if (resultMonthNum != 7 || resultDayNum != 6)
        {
            Console.Error.WriteLine($" The month {resultMonthNum} and day {resultDayNum} are not correst, they should 7 and 6");
            return false;
        }

        // 2. What happens if you pass the arguments "banana", "boy"? What should happen?
        try
        {
            WeatherPredictionService.GettingDate.ValidateDate("Banana", "Boy");
            Console.Error.WriteLine(" We expected a valid date that include integers");
            return false;
        }
        catch (Exception e)
        {
            // Received valid date 
        }

        // 3. What happens if you pass the arguments "-5", "33"?
        try
        {
            WeatherPredictionService.GettingDate.ValidateDate("19", "57");

            Console.Error.WriteLine(" We expected an expection from loading a month and day out of range");
            return false;
        }
        catch (Exception e)
        {
            // code worked correctly
        }
        // 4. Come up with different tests for this method.
        return true;
    }
}