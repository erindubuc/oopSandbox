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
            Teacher teacher = new Teacher("Albus Dumbledore", "Programming with C#");
            Console.WriteLine("New teacher added: " + teacher.TeacherName + " to teach " + teacher.Course);

            // Instantiate a Degree object, such as Bachelor
            Degree bachDegree = new Degree("Bachelor");


            // Add your Course object to the Degree object
            bachDegree.Course = course;
            Console.WriteLine("The course, " + course.CourseName + " has been added to the " + bachDegree.DegreeName + " program");

            // Instantiate UProgram object called IT
            UProgram uProgram = new UProgram("Information Technology");
            Console.WriteLine("Added new program: " + uProgram.ProgramName);

            // Add the Degree object to the UProgram object
            uProgram.Degree = bachDegree;

            // Using Console.WriteLine statements, output the following information to the console window:
            // The name of the program and the degree it contains
            Console.WriteLine("The program " + uProgram.ProgramName + " has a " + bachDegree.DegreeName + " Degree.");

            // The name of the course in the degree
            Console.WriteLine("The " + bachDegree.DegreeName + " Degree offers the course: " + course.CourseName);

            // The count of the number of students in the course.
            Console.WriteLine("There are {0} students enrolled.", students[0].AddStudents());
        }
    }
}
