using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarks
{
    public class StudentGrades
    {
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        public StudentGrades()
        {
            Students = new string[] { "Daniel", "Dylan", "Eric", "Georgia", "Hasan", "Hamza", "Jack", "Liam", "Shan", "Shamial" };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];

        }

        public void CalculateGradeProfile()
        {
            throw new NotImplementedException();
        }

        public void OutputGradeProfile()
        { 
            throw new NotImplementedException();
        }
        public void OutputGrades()
        {
            throw new NotImplementedException();
        }
        public void OutputMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Out.WriteLine("- - - - - - - - - - - - - - - - - - - - -");
            Console.Out.WriteLine("-          Students Grades App          -");
            Console.Out.WriteLine("-          by Kamil Lesniewski          -");
            Console.Out.WriteLine("- - - - - - - - - - - - - - - - - - - - -");
            Console.ForegroundColor = ConsoleColor.White;

            //Console.Out.WriteLine();
            Console.Out.WriteLine();
            Console.Out.WriteLine("1. Input marks");
            Console.Out.WriteLine("2. Output marks");
            Console.Out.WriteLine("3. Output stats");
            Console.Out.WriteLine("4. Output Grade Profile");
            Console.Out.WriteLine("5. Quit \n");
        }
        
        public void OutputStats()
        {
            throw new NotImplementedException();
        }

        public void InputMarks()
        {
            int mark;
            int i = 0;
            string input;
            bool confirm = false;
            
            Console.Out.Write("Would you like to confirm each grade?(Y/N): ");
            input = Console.ReadLine();
            if (input.ToUpper() == "Y") confirm = true;
            
            foreach (var item in Students)
            {
                Console.Out.Write("Mark for " + item + " > ");
                do
                {
                    input = Console.ReadLine();
                    mark = Convert.ToInt32(input.Length > 0 ? input : "-1");
                    if (mark < 0 || mark > 100)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Out.WriteLine("Please enter the correct grade!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Out.Write("Mark for " + item + " > ");
                    }
                    else
                    {
                        if (confirm)
                        {
                            Console.Write("Are you sure you want to give " + item + " grade of " + mark + "?(Y/N): ");
                            input = Console.ReadLine();
                            if (input.ToUpper() == "Y") Marks[i] = mark;
                            else
                            {
                                mark = -1;
                                Console.Out.Write("Mark for " + item + " > ");
                            }
                        } else Marks[i] = mark;
                    }
                } while (mark < 0 || mark > 100);
                i++;
            }
            Console.ReadKey();
            Console.Clear();
        }

        public void OutputMarks()
        {
            int i = 0;
            foreach (var item in Students)
            {
                Console.Out.WriteLine("Mark for " + item + " is " + Marks[i] + "(" + ConvertToGrade(Marks[i]).ToString() + ")");
                i++;
            }
            Console.ReadKey();
        }

        public Grades ConvertToGrade(int mark)
        {
            Grades result = Grades.F;
            switch(mark)
            {
                case int n when (n >= 70 && n <= 100):
                    //Console.WriteLine($"I am First Class: {n}");
                    result = Grades.A;
                    break;

                case int n when (n >= 60 && n <= 69):
                    //Console.WriteLine($"I am Upper: {n}");
                    result = Grades.B;
                    break;

                case int n when (n >= 50 && n <= 59):
                    //Console.WriteLine($"I am Lower: {n}");
                    result = Grades.C;
                    break;

                case int n when (n >= 40 && n <= 49):
                    //Console.WriteLine($"I am Third Class: {n}");
                    result = Grades.D;
                    break;

                case int n when (n >= 0 && n <= 39):
                    //Console.WriteLine($"I am Failure: {n}");
                    result = Grades.F;
                    break;
            }
            return result;
        }
        public void CalculateStats()
        {
            throw new NotImplementedException();
        }


    }
}
