using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    abstract class Question
    {
        public string Text { get; set; }
        public int Mark { get; set; }

        public Question(string text, int mark)
        {
            Text = text;
            Mark = mark;
        }

        public abstract void Display();
    }

    class MCQ : Question
    {
        public List<string> Options { get; set; }
        public string CorrectAnswer { get; set; }

        public MCQ(string text, int mark, List<string> options, string correct) : base(text, mark)
        {
            Options = options;
            CorrectAnswer = correct;
        }

        public override void Display()
        {
            Console.WriteLine($"Q: {Text}");
            foreach (var opt in Options)
                Console.WriteLine($"- {opt}");
        }
    }

    class TrueFalse : Question
    {
        public bool CorrectAnswer { get; set; }

        public TrueFalse(string text, int mark, bool answer) : base(text, mark)
        {
            CorrectAnswer = answer;
        }

        public override void Display()
        {
            Console.WriteLine($"Q: {Text} (True/False)");
        }
    }

    class essay : Question
    {
        public essay(string text, int mark) : base(text, mark) { }

        public override void Display()
        {
            Console.WriteLine($"Essay Q: {Text}");
        }
    }
}