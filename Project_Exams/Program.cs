using System;
using System.Collections.Generic;
using project;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create course
            Course c1 = new Course("OOP", "Object Oriented Programming", 100);

            // Create students
            Student s1 = new Student(1, "Asma", "asma@mail.com");
            Student s2 = new Student(2, "Nesma", "nesma@mail.com");



            s1.Enroll(c1);
            s2.Enroll(c1);

            // Create instructor
            Instructor ins = new Instructor(1, "Dr. Ahmed", "Software");
            ins.AssignCourse(c1);

            // Create exam
            Exams exam = new Exams("Midterm", c1);

            exam.AddQuestion(new MCQ("OOP stands for?", 20, new List<string> { "Object", "Oriental", "Other" }, "Object"));
            exam.AddQuestion(new TrueFalse("Inheritance is part of OOP", 10, true));
            exam.AddQuestion(new essay ("Explain Polymorphism", 30));

            exam.StartExam();

            // Reports
            Report.ShowReport(exam.Title, s1, c1, 50);
            Report.ShowReport(exam.Title, s2, c1, 70);
            Report.Compare(s1, 50, s2, 70);
        }
    }
}