using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_L
{
    class Question
    {
       public string Text { get; set; }
        
       public List<Answer> Answers { get; set; }
        public Question()
        {
        }
        public Question(string text, List<Answer> answers)
        {
            Text = text;
            Answers = answers;

        }
        public bool CheckAnswer(string answ)
        {
            foreach(var n in Answers)
            {
                if(n.Text == answ &&n.IsCorrect)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{Text}" +
                $"\nA){Answers[0]}" +
                $"\nB){Answers[1]}" +
                $"\nC){Answers[2]}" +
                $"\nD){Answers[3]}";
        }

    }
}
