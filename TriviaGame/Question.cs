using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    class Question
    {
        public string Questions { get; set; }
        public string Answer { get; set; }

        public bool isCorrect(string answer)
        {
            return string.Compare(answer, Answer, true) == 0;
        }
    }
}
