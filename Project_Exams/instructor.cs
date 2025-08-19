using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Instructor : Person
    {
        public string Specialization { get; set; }
        public List<Course> Courses { get; set; }

        public Instructor(int id, string name, string specialization) : base(id, name)
        {
            Specialization = specialization;
            Courses = new List<Course>();
        }

        public void AssignCourse(Course course)
        {
            Courses.Add(course);
        }
    }
}
