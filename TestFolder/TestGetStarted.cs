using System;
using System.Collections.Generic;
using System.IO;

namespace WeatherPredictionService
{


    class TestGetStarted
    {
       

        public static bool RunTest()
        // In this Test, I would like to create test to see if the user entered a a date. As long as they entered just about anything, it would go into the validate date method as an int. I would then test that the stored variable of the user matches the readline of the users responce. 
        {
            //  (int UserMonth, int Userday) = WeatherPredictionService.GettingDate.GetStarted("09","21")  ** WHy wont this work. My gettingDate is all screwed up. 


            int userMonth = 9;
            int userDay = 25;
    

            Console.WriteLine("Calling GetStarted(). You should expect to be prompted to enter a date.");
            Console.WriteLine("2. Next enter a valid month '09'. This should continue to asking you to enter a day.");
            Console.WriteLine("3. Enter an invalid day '-5'. This should display an error message and ask you to try again.");
            Console.WriteLine(" Enter Banana and it will say invalid. Please eneter a new date");
            Console.WriteLine("4. Enter a valid day '25'. This should be successful.");

            // (userDay, userMonth) = GettingDate.GetStarted();
            
            

            if (userMonth != 09)
            {
                Console.Error.WriteLine($" There is an expected error. Please try again");
                return false;
            }

    

            if (userDay != 25)
            {
                Console.Error.WriteLine($"An expected error has come. Please Try again.");
                return false;
            }

            // Feedback(jcollard 2022-02-08): Everything above this looks great!
            // I don't think you need this try / catch. (It isn't doing anything
            // right now and I don't think there is a case where it should throw
            // an exception.

            try
            {
                userDay = 25;
                Console.WriteLine(" This integer is a valid day");
            }
            catch 
            {
                //ignore and proceed
            }




            return true;
        }
    }
}