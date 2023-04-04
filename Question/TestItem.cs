using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTUI.Question
{
    internal class TestItem
    {
        public string Question { get; private set; }
       // public string Answer { get; set; }
        public string CorrectAnswer { get; private set; }
        public TestItem(string question,string correctAnswer) 
        { 
            this.Question = question;
            //this.Answer = null;
            this.CorrectAnswer = correctAnswer;
        }
    }
}
