using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_L

{
    internal class Answer
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }

        public Answer()
        {

        }
        public Answer(string text,bool isCorecct)
        {
            Text = text;
            IsCorrect = isCorecct;
        }
        public override string ToString()
        {
            return $"{Text}";
        }

    }
}
