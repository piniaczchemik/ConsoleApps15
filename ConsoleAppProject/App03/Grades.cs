using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarks
{
    public enum Grades
    {
        [Description("Fail")]
        F,
        [Description("Third Class")]
        D, 
        [Description("Lower Second")]
        C,
        [Description("Upper Second")]
        B,
        [Description("First Class")]
        A
    }
}
