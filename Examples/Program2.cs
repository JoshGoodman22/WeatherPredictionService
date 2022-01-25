using System;
using System.Collections.Generic;
using System.Linq;

namespace WeatherData
{
    class Program2
    {

        // Columns
        // 0 dt,
        // 1 dt_iso,
        // 2 timezone,
        // 3 city_name,
        // 4 lat,
        // 5 lon,
        // 6 temp,
        // 7 visibility,
        // 8 dew_point,
        // 9 feels_like,
        // 10 temp_min,
        // 11 temp_max,
        // 12 pressure,
        // 13 sea_level,
        // 14 grnd_level,
        // 15 humidity,
        // 16 wind_speed,
        // 17 wind_deg,
        // 18 wind_gust,
        // 19 rain_1h,
        // 20 rain_3h,
        // 21 snow_1h,
        // 22 snow_3h,
        // 23 clouds_all,
        // 24 weather_id,
        // 25 weather_main,
        // 26 weather_description,
        // 27 weather_icon
        public static void Main2()
        {
            Console.WriteLine("Loading Database!");
            List<string> lines = System.IO.File.ReadAllLines("HistoricalWeatherDataLA.csv").ToList();
            Console.WriteLine($"Done! {lines.Count} dates loaded.");
            string header_line = lines[0]; // The first line just contains the headers
            Random gen = new Random();
            int random_entry = gen.Next(1, lines.Count); // Randomly select a row
            string random_line = lines[random_entry]; // A random entry in the file

            List<string> first_line_data = random_line.Split(",").ToList();
            string date = first_line_data[1]; // The second column has a human readable date
            string min_temp_text = first_line_data[10]; // The 11th column has the min temp
            string max_temp_text = first_line_data[11]; // The 12th column has the max temp
            string avg_temp_text = first_line_data[6]; // The 7th column has the average temp

            float min_temp = float.Parse(min_temp_text); // Converts min temp to a float
            float max_temp = float.Parse(max_temp_text); // Converts max temp to a float
            float avg_temp = float.Parse(avg_temp_text); // Converts the average temp to a float

            Console.WriteLine($"On {date} the average temp was {avg_temp} K.");

            

            int userMonth = 7;
            int userDay = 5;
            // Console.WriteLine($"The date is: {yearMonthDay}");
            // Console.WriteLine($"The month is: {month}");

            foreach(string line in lines)
            {
                List<string> row = line.Split(",").ToList();
                date  = row[1]; // The second column has a human readable date
                if(date.Length < 10) continue;
                string yearMonthDay = date.Substring(0,10);
                int month = int.Parse(yearMonthDay.Substring(5,2));
                int day = int.Parse(yearMonthDay.Substring(8,2));
                if(month == userMonth && day == userDay)
                {
                    Console.WriteLine(line);
                }
            }

        }
    }
}
