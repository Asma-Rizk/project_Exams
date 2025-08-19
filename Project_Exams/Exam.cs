using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Exams
    {
        public string Title { get; set; }
        public Course Course { get; set; }
        public List<Question> Questions { get; set; }
        public bool Started { get; private set; }

        public Exams(string title, Course course)
        {
            Title = title;
            Course = course;
            Questions = new List<Question>();
            Started = false;
        }

        public void AddQuestion(Question q)
        {
            if (Started)
            {
                Console.WriteLine("Exam already started. Can't modify.");
                return;
            }

            int totalMarks = 0;
            foreach (var item in Questions) totalMarks += item.Mark;

            if (totalMarks + q.Mark <= Course.MaximumDegree)
                Questions.Add(q);
            else
                Console.WriteLine("Can't add question. Exceeds maximum degree.");
        }

        public void StartExam()
        {
            Started = true;
            Console.WriteLine($"Exam {Title} started for course {Course.Title}");
        }
    }
}
