using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This class offers methods for converting a given
    /// distance measured in miles to equivalent 
    /// distance measured in feet
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// Kamil Lesniewski 21906354
    public class DistanceConverter 
    {
        public const int FEET_IN_MILES = 5280;
        
        private double miles;

        private double feet;

       /// <summary>
       /// 
       /// </summary>
        public void Run() 
        {
            OutputHeading();
            InputMiles();
            Calculatefeet();
            outputFeet();
        }

        private void OutputHeading()
        {
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("       Convert Miles to Feet         ");
            Console.WriteLine("        By Kamil Lesniewski          ");
            Console.WriteLine("-----------------------------------\n");
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        private void InputMiles() 
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }
        private void Calculatefeet() 
        {
            feet = miles * 5280;
        }
    
        private void outputFeet() 
        {
            Console.WriteLine(miles + " miles is " + feet + " feet! ");
        }

    }
}
