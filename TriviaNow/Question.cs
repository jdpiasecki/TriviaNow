//Jeff Piasecki CIS 345 Project 12:00
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaNow
{
    [Serializable]

    public class Question
    {
        private List<string> choice;
        string myQuestion;
        string feedback;
        string correctChoice;

        public Question()
        {
            Choice = new List<string>();
        }

        //constructor for creating a question along 
        public Question(string myQuestion, string choice1, string choice2, string choice3, string choice4, string correctChoice, string feedback)
        {
            this.myQuestion = myQuestion;
            Choice = new List<string>();
            Choice.Add(choice1);
            Choice.Add(choice2);
            Choice.Add(choice3);
            Choice.Add(choice4);
            this.correctChoice = correctChoice;
            this.feedback = feedback;
        }

        public string MyQuestion { get => myQuestion; set => myQuestion = value; }
        public string Feedback { get => feedback; set => feedback = value; }
        public string CorrectChoice { get => correctChoice; set => correctChoice = value; }
        public List<string> Choice { get => choice; set => choice = value; }

        public override string ToString()
        {
            return MyQuestion;
        }
    }

}
