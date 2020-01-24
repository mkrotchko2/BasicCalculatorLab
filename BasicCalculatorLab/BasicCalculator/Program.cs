using System;

namespace BasicWeatherCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC CALCULATOR ***");

            Console.WriteLine("Enter the temperature (in degrees F)");

            int Temperature = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Humidity");
            int Humidity = int.Parse(Console.ReadLine());

            int dewpoint = Temperature - 9 * (100 - Humidity) / 25;

            Console.WriteLine("The Dew Point is" + dewpoint);


            Console.WriteLine("Enter the Wind Speed");
            int windspeed = int.Parse(Console.ReadLine());


            double windchill = 35.74
                + (0.6215 * Temperature)
                - 35.75 * Math.Pow(windspeed, .16)
                + .4275 * Temperature * Math.Pow(windspeed, .16);
            
                Console.WriteLine ("The Wind Chill is"+windchill);
        }

    }
}
