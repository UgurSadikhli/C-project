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
        public List<Question> Q { get; set; }
        public override string ToString()
        {
            return $"{Text}:" +
                $"\nA){Q[0]}" +
                $"\nB){Q[1]}" +
                $"\nC){Q[2]}" +
                $"\nD){Q[3]}";
        }
    }


}
