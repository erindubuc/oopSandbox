using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessment
{
    public class Teacher
    {
        // Defining properties
        public string TeacherName { get; set; }
        public string Course { get; set; }

        // Adding a constructor
        // Instantiates Teacher with course
        public Teacher(string teacherName, string courseName)
        {
            this.TeacherName = teacherName;
            this.Course = courseName;
        }
    }
}
