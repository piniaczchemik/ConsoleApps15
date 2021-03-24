using System;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using StudentMarks;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Kamil Lesniewski 01/02/2021
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();
            Console.Beep();
            Console.WriteLine("|1. Distance converter");
            Console.WriteLine("|2. BMI calculator");
            Console.WriteLine("|3. Student Marks");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    {
                        DistanceConverter converter = new DistanceConverter();
                        converter.Convert();
                        break;
                    }

                case "2":
                    {
                        BMI calculator = new BMI();
                        calculator.Main();
                        break;
                    }
                case "3":
                    {
                        StudentGrades studentGrades = new StudentGrades();
                        UserLib.SelectChoice(studentGrades);
                        break;
                    }
            } 
            }
        }
    }

