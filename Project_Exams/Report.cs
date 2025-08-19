using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Report
    {
        public static void ShowReport(string examTitle, Student student, Course course, int score)
        {
            string status = score >= (course.MaximumDegree / 2) ? "Pass" : "Fail";
            Console.WriteLine($"Exam: {examTitle}, Student: {student.Name}, Course: {course.Title}, Score: {score}, Status: {status}");
        }

        public static void Compare(Student s1, int score1, Student s2, int score2)
        {
            Console.WriteLine($"{s1.Name}: {score1} vs {s2.Name}: {score2}");
            Console.WriteLine(score1 > score2 ? $"{s1.Name} scored higher" : $"{s2.Name} scored higher");
        }
    }
}
