using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor currInstructor = new Instructor()
            {
                FullName = "Homer Simpson",
                Email = "hSimpson@cptc.edu"
            };

            Student S1 = new Student()
            {
                FirstName = "Jim ",
                LastName = "Halpert"
            };

            Student S2 = new Student()
            {
                FirstName = "Kelly ",
                LastName = "Kapoor"
            };

            Course testCourse = new Course();
            testCourse.Title = "CPW 212 Adv .NET";
            testCourse.Description = "More .Net";
            testCourse.Credits = 5;
            testCourse.CourseInstructor = currInstructor;
            testCourse.Roster = new List<Student>();

            testCourse.Roster.Add(S1);
            testCourse.Roster.Add(S2);

            Console.WriteLine(testCourse.Title);
            Console.WriteLine("Is taught by " + 
                testCourse.CourseInstructor.FullName);

            Console.WriteLine("Currently enrolled students: ");
            foreach (Student s in testCourse.Roster)
            {
                Console.WriteLine($"{s.FirstName}{s.LastName}");
            }
            Console.ReadKey();
        }
    }
}
