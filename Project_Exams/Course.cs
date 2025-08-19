using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Course
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int MaximumDegree { get; set; }

        public Course(string title, string description, int maxDegree)
        {
            Title = title;
            Description = description;
            MaximumDegree = maxDegree;
        }

        public void DisplayCourse()
        {
            Console.WriteLine($"Course: {Title}, Max Degree: {MaximumDegree}");
        }
    }
}
