using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarks
{
    public static class UserLib
    {
        public static void SelectChoice(StudentGrades studentGrades)
        {
            StudentGrades execute = studentGrades;
            int choice = 0;
            string input;
            do
            {
                execute.OutputMenu();
                Console.Out.Write("Please enter your choice: ");
                input = Console.ReadLine();
                if (input.Length > 0) choice = Convert.ToInt32(input);
                else choice = 0;
                switch (choice)
                {
                    case 1:
                        execute.InputMarks();
                        break;
                    case 2:
                        execute.OutputMarks();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        continue;
                }
            } while (choice != 5);
        }
    }
}
