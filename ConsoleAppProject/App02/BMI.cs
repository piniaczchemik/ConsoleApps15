namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>

    using System;

    
    
        public class BMI
        {
            private int weight, height;
            private double BMIvalue;
            private const string MEASUREMENT = "METRIC"; //switch mode between METRIC/IMPERIAL
            public void Main()
            {
                BMI bMI = new BMI(); //create new object
                bMI.getDetails(MEASUREMENT); //call methods
                bMI.calcBMI(MEASUREMENT);
                bMI.displayBMI();
                System.Threading.Thread.Sleep(5000);
            }

            public BMI() //constructor
            {
                weight = height = 0; //set default value
                BMIvalue = 0;
            }

            public void getDetails(string measurement)
            {
                Console.Write("Please tell me your weight in " + (measurement.ToLower() == "metric" ? "kgs" : "punds") + ": ");
                weight = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please tell me your height in " + (measurement.ToLower() == "metric" ? "cms" : "inches") + ": ");
                height = Convert.ToInt32(Console.ReadLine());
                //shorthand if property determines units
            }

            public void calcBMI(string measurement)
            {
                if (measurement.ToLower() == "metric") BMIvalue = weight / Math.Pow(height, 2) * 10000; //formula for METRIC
                else if (measurement.ToLower() == "imperial") BMIvalue = weight * 703 / Math.Pow(height, 2); // formula for IMPERIAL
                else BMIvalue = -1; //error code when bad unit chosen
                Console.Write("\n\n{0:0.00} - ", BMIvalue);//display calculated bmi
            }

            public void displayBMI() // series of BMI comments depending on range
            {
                if (BMIvalue < 18.5) Console.WriteLine("Underweight");
                else if (BMIvalue >= 18.5 && BMIvalue < 25) Console.WriteLine("Desirable weight for size");
                else if (BMIvalue >= 25 && BMIvalue < 30) Console.WriteLine("Overweight");
                else if (BMIvalue >= 30 && BMIvalue < 40) Console.WriteLine("Obese");
                else Console.WriteLine("Severly obese");
            }
        }
    }
