using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessment
{
    public class Course
    {
        // Defining properties
        public string CourseName { get; set; }

        // Students and Teachers for course
        public Student[] Student { get; set; }
        public Teacher[] Teacher { get; set; }
       

        // Adding a constructor to instantiate Course()
        public Course()
        {

        }

        public Course(string courseName)
        {
            this.CourseName = courseName;
        }

        // Constructor for Course to show students and teacher 
        public Course(Student[] students, Teacher[] teachers, string courseName)
        {
            this.Student = students;
            this.Teacher = teachers;
            this.CourseName = courseName;
        }

       
    }
}
