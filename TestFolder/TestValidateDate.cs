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
        if (resultNum != 9 && resultDay != 14)
        {
            // If the resultNum and resultDay were not correct, the method is failing. Print a message
            // saying the method is not working as intended.
            return false;
        }

        // 2. What happens if you pass the arguments "banana", "boy"? What should happen?
        // 3. What happens if you pass the arguments "-5", "33"?
        // 4. Come up with different tests for this method.
        return false;
    }
} 