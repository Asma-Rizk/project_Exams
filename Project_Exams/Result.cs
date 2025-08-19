using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Result
    {

        public Student Student { get; }
        public Exams Exam { get; }
        public int Score { get; }
        public bool Pass { get; }
        
        public Result(Student student, Exams exam, int score, bool pass)
        {
            Student = student;
            Exam = exam;
            Score = score;
            Pass = pass;
        }
    }
}
