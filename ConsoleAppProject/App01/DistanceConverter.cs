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

        public const double METRES_IN_MILES = 1609.34;
        
        private double miles;

        private double feet;

        private double metres;

       /// <summary>
       /// This method will input the distance measured in miles
       /// calculate the same distance in feet, and output the 
       /// distance in feet.
       /// </summary>
       
        public void MilesToFeet()
        {
            OutputHeading("Converting Miles To Feet");

            miles = InputDistance(" please enter the number of miles > ");
            CalculateFeet();
            OutputDistance(miles, nameof(miles), feet, nameof(feet));
        }

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");

            feet = InputDistance(" please enter the number of feet > ");
            CalculateMiles();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }

        public void MilesToMetres()
        {
            OutputHeading("Converting Miles to Metres");

            miles = InputDistance(" please enter the number of miles > ");
            CalculateMetres();
            OutputDistance(miles, nameof(miles), metres, nameof(metres));
        }

        private void InputFromDistance()
        {
            Console.WriteLine("Please chose one of the following units to convert from!");
            Console.WriteLine("Feet, Miles or Metres");
            string value;
        }
        public void Run() 
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        private void InputMiles()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        private double InputDistance(string prompt) 
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

            /// <summary>
        /// 
        /// </summary>

        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        /// <summary>
        /// 
        /// </summary>
        
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        /// <summary>
        /// 
        /// </summary>
        
        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        private void OutputDistance(double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance}  {fromUnit} + is {toDistance } { toUnit}!");
        }

        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }


        private void OutputHeading(String prompt)
        {
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("         Distance Converter        ");
            Console.WriteLine("         By Kamil Lesniewski          ");
            Console.WriteLine("-----------------------------------\n");

            Console.WriteLine("Prompt");
            Console.WriteLine();
        }
    }
}
