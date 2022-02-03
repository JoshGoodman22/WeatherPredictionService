using System;
using System.Collections.Generic;
using System.IO;

namespace WeatherPredictionService
{

}
class TestGetStarted
{
public static bool RunTest()
// In this Test, I would like to create test to see if the user entered a a date. As long as they entered just about anything, it would go into the validate date method as an int. I would then test that the stored variable of the user matches the readline of the users responce. 
    {
    //  (int UserMonth, int Userday) = WeatherPredictionService.GettingDate.GetStarted("09","21")  ** WHy wont this work. My gettingDate is all screwed up. 


    // TODO(jcollard 2022-02-03): Your GetStarted method has this signature:
    // public static void GetStarted(string[] args)
    // It is expecting an Array of strings as an argument (input) and is void so it doesn't return anything
    // Your code is giving it 2 strings and in the above code you're assuming it returns (int, int).
    // If you had the following signature on GetStarted, it would work:
    // public static (int, int) GetStarted(string month, string day);
    // Is that what you're trying to do?


    // I believe instead, you want to write a test which gives the tester instructions:

    Console.WriteLine("Calling GetStarted(). You should expect to be prompted to enter a date.");
    Console.WriteLine("1. Start by entering an invalid date 'banana'. This should display an error message and ask you to try again.");
    Console.WriteLine("2. Next enter a valid month '09'. This should continue to asking you to enter a day.");
    Console.WriteLine("3. Enter an invalid day '-5'. This should display an error message and ask you to try again.");
    Console.WriteLine("4. Enter a valid day '25'. This should be successful.");

    // Next, you should change the the signature of your GetStarted message to this:
    // public static (int, int) GetStarted(); // No parameters but it should return 2 ints.

    // Now, call the method and assume the tester follows the above instructions:

    // (int userMonth, int userDay) = WeatherPredictionService.GettingDate.GetStarted();

    // Test that userMonth and userDay are the expected values. In this case:

    // if (userMonth != 9)
    // {
    //     return false;
    // }

    // if (userDay != 25)
    // {
    //     return false;
    // }
     

        return false;
    }
}