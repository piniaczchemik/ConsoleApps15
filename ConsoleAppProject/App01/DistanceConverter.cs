using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This class offers methods for converting a given
    /// distance measured in miles to equivalent 
    /// distance measured in feet.
    /// </summary>
    /// <author>
    /// Student Name version 0.3
    /// Kamil Lesniewski 21906354
    public class DistanceConverter 
    {
        public const int FEET_IN_MILES = 5280;

        public const double METERS_IN_MILES = 1609.34;
        
        private string fromUnit;

        public string toUnit;

        public double fromDistance;

        public double toDistance;



       /// <summary>
       /// This method will input the distance measured in miles
       /// calculate the same distance in feet, and output the 
       /// distance in feet.
       /// </summary>
       
    
       
        private void OutputHeading()
        {
            string heading = @"
---------------------------
     Distance Converter
     By Kamil Lesniewski
---------------------------

1. Feet
2. Meters
3. Miles


Please select your units";

            Console.WriteLine(heading);
        }

        public void Convert()
        {
            OutputHeading();

            string[] input = Console.ReadLine().ToLower().Split(" ");

            fromDistance = float.Parse(input[0]);
            fromUnit = input[1];

            Console.WriteLine(" Convert " + fromDistance + " " + fromUnit + " into...");
            toUnit = Console.ReadLine().ToLower();

            if (fromUnit == "miles" && toUnit == "feet")// miles into feet
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            if (fromUnit == "miles" && toUnit == "meters")// miles into meters
            {
                toDistance = fromDistance * METERS_IN_MILES;
            }

            if (fromUnit == "feet" && toUnit == "meters") // feet into meters
            {
                toDistance = fromDistance * 0.3048;
            }
            if (fromUnit == "feet" && toUnit == "miles") // feet into miles
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }

            if (fromUnit == "meters" && toUnit == "feet")// meters into feet
            {
                toDistance = fromDistance * 3.281;
            }
            if (fromUnit == "meters" && toUnit == "miles") // meters into miles
            {
                toDistance = fromDistance / METERS_IN_MILES;
            }

            Console.WriteLine("That equals: " + toDistance + " " + toUnit);


        }
    }
}
