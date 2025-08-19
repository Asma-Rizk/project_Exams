using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Student : Person
    {
        public string Email { get; set; }
        public List<Course> Courses { get; set; }

        public Student(int id, string name, string email) : base(id, name)
        {
            Email = email;
            Courses = new List<Course>();
        }

        public void Enroll(Course course)
        {
            Courses.Add(course);
            Console.WriteLine($"{Name} enrolled in {course.Title}");
        }

    }
}