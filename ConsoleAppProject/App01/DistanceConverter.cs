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

            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");

            Inputfeet();
            CalculateMiles();
            OutputMiles();
        }

        public void MilesToMetres()
        {
            OutputHeading("Converting Miles to Metres");

            InputMiles();
            CalculateMetres();
            OutputMetres();
        }
        public void Run() 
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
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

        private void InputMetres()
        {
            Console.Write("Please enter the number of metres > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
         }
        private void Inputfeet()
        {
            Console.Write("Please enter the number of feet > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
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

        /// <summary>
        /// 
        /// </summary>
        /// 

        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }

        /// <summary>
        /// 
        /// </summary>
        
        private void OutputMiles() 
        {
            Console.WriteLine(feet + " feet is " + miles + " miles!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// 

        private void OutputMetres()
        {
            Console.WriteLine(miles + " miles is " + metres + " metres!");
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
