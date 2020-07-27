using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Course
    {
        /// <summary>
        /// Full Title of course ex CPW 212 - . Adv .NET Programming
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Course catalog offical description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Number of credits course is worth
        /// </summary>
        public byte Credits { get; set; }

        /// <summary>
        /// The instrucor that teaches the course
        /// </summary>
        public Instructor CourseInstructor { get; set; }

        /// <summary>
        /// All the student currently enrolled in the class
        /// </summary>
        public List<Student> Roster { get; set; }
    }
}
