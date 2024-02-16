using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_L
{
    class Questions_List
    {
        public List<Question> questions = new List<Question>
        {
            new Question()
            {
                Text = "How are you ?",
                Answers = new List<Answer>()
                {
                    new Answer() { Text = "good",IsCorrect = false},
                    new Answer() { Text = "bad",IsCorrect = true},
                    new Answer() { Text = "wort",IsCorrect = false},
                    new Answer() { Text = "soo bad",IsCorrect = false}
                }
            },
            new Question()
            {
                Text = "What is your name ?",
                Answers = new List<Answer>()
                {
                    new Answer() { Text = "murad",IsCorrect = false},
                    new Answer() { Text = "ugur",IsCorrect = true},
                    new Answer() { Text = "natiq",IsCorrect = false},
                    new Answer() { Text = "umid",IsCorrect = false}

                }

            },
        };
    }
}
