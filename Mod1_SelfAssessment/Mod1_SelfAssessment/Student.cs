using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessment
{
    // Declaring the Student() Class
    // Properties: Degree, Course
    public class Student
    {
        // Defining properties
        public string StudentName { get; set; }
        public int Id { get; set; }
        public Degree Degree { get; set; }
        public Course Course { get; set; }
        public static int NumStudents { get; set; }

        // Adding a constructor
        // Instantiates Student with degree and course
        public Student(string studentName, int id)
        {
            this.StudentName = studentName;
            this.Id = id;
            NumStudents++;
        }

        public int AddStudents()
        {
            return NumStudents; 
        }
        
    }
}
