using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_SelfAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate UProgram object called IT
            UProgram uProgram = new UProgram("Information Technology");
            Console.WriteLine("Added new program: " + uProgram.ProgramName);

            // Instantiate 3 Student objects
            //Student student1 = new Student("Harry Potter", 9341);
            //Student student2 = new Student("Ron Weasley", 9342);
            //Student student3 = new Student("Hermione Granger", 9343);

            Student[] students =
                {
                    new Student("Harry Potter", 9341),
                    new Student("Ron Weasley", 9342),
                    new Student("Hermione Granger", 9343)
                };

            Console.WriteLine("New students added: " + students[0].StudentName + ", " + students[1].StudentName + ", and " + students[2].StudentName);

            // Instantiate a Course object "Programming with C#"
            Course course = new Course("Programming with C#");
            Console.WriteLine("New course added: " + course.CourseName);

            // Add the 3 students to this Course object
            course.Student = students;
            Console.WriteLine($"Students enrolled in " + course.CourseName + ": {0}, {1}, and {2}", students[0].StudentName, students[1].StudentName, students[2].StudentName);

            // Instantiate at least one Teacher object

            // Add that Teacher object to your Course object

            // Instantiate a Degree object, such as Bachelor

            // Add your Course object to the Degree object

            // Instantiate a UProgram object called Information Technology

            // Add the Degree object to the UProgram object

            // Using Console.WriteLine statements, output the following information to the console window:
                // The name of the program and the degree it contains
                // The name of the course in the degree
                // The count of the number of students in the course.
        }
    }
}
