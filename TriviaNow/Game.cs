//Jeff Piasecki CIS 345 Project 12:00
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TriviaNow
{
    

    public partial class Game : Form
    {
        List<Question> gameQuestions;
        int questionNumber = 0;
        int scoreTrack = 0;
        SoundPlayer themeSong;
        int questionNum = 1;
        

        public Game()
        {
            InitializeComponent();
        }

        public Game(List<Question> threeQuestions)
        {
            InitializeComponent();
            gameQuestions = threeQuestions;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            //loads the music and game
           themeSong = new SoundPlayer("theme.wav");
           themeSong.Load();
           themeSong.PlayLooping();
           
            gameOverBox.Visible = false;
            resultsLabel.Visible = false;
            exitButton.Visible = false;
            DisplayQuestion();
            
        }
        // displays questions with choices, feedback is hidden until answered
        private void DisplayQuestion()
        {
            feedbackLabel.Visible = false;
            correctLabel.Visible = false;
            nextQuestion.Visible = false;
            questionLabel.Text = gameQuestions[questionNumber].MyQuestion;
            choice1Button.Text = gameQuestions[questionNumber].Choice[0];
            choice2Button.Text = gameQuestions[questionNumber].Choice[1];
            choice3Button.Text = gameQuestions[questionNumber].Choice[2];
            choice4Button.Text = gameQuestions[questionNumber].Choice[3];
            feedbackLabel.Text = gameQuestions[questionNumber].Feedback;
            choice1Button.Enabled = true;
            choice2Button.Enabled = true;
            choice3Button.Enabled = true;
            choice4Button.Enabled = true;
            //displays current question out of 3
            questNum.Text = $"Question: {questionNum} of 3";
        }
        // buttons will display correct or incorrect if the user answers the question correctly
        //first button choice checks for correct answer
        //each selection will increment the question number out of 3
        private void choice1Button_Click(object sender, EventArgs e)
        {
            Button tmpButton = (Button)sender;
            int correctChoice = Convert.ToInt32(gameQuestions[questionNumber].CorrectChoice);
            if (tmpButton.Text == gameQuestions[questionNumber].Choice[correctChoice])
            {
                correctLabel.Text = "Correct";
                correctLabel.Visible = true;
                feedbackLabel.Visible = true;
                nextQuestion.Visible = true;
                scoreTrack++;
                choice1Button.Enabled = false;
                choice2Button.Enabled = false;
                choice3Button.Enabled = false;
                choice4Button.Enabled = false;
                questionNum++;
            }
            else
            {
                correctLabel.Text = "Incorrect";
                correctLabel.Visible = true;
                feedbackLabel.Visible = true;
                nextQuestion.Visible = true;
                choice1Button.Enabled = false;
                choice2Button.Enabled = false;
                choice3Button.Enabled = false;
                choice4Button.Enabled = false;
                questionNum++;
            }
        }

        //second button choice, checks for correct answer
        private void choice2Button_Click(object sender, EventArgs e)
        {
            Button tmpButton = (Button)sender;
            int correctChoice = Convert.ToInt32(gameQuestions[questionNumber].CorrectChoice);
            if (tmpButton.Text == gameQuestions[questionNumber].Choice[correctChoice])
            {
                correctLabel.Text = "Correct";
                correctLabel.Visible = true;
                feedbackLabel.Visible = true;
                nextQuestion.Visible = true;
                scoreTrack++;
                choice1Button.Enabled = false;
                choice2Button.Enabled = false;
                choice3Button.Enabled = false;
                choice4Button.Enabled = false;
                questionNum++;

            }
            else
            {
                correctLabel.Text = "Incorrect";
                correctLabel.Visible = true;
                feedbackLabel.Visible = true;
                nextQuestion.Visible = true;
                choice1Button.Enabled = false;
                choice2Button.Enabled = false;
                choice3Button.Enabled = false;
                choice4Button.Enabled = false;
                questionNum++;
            }
        }

        //third button choice, checks to see if the anser is correct
        private void choice3Button_Click(object sender, EventArgs e)
        {
            Button tmpButton = (Button)sender;
            int correctChoice = Convert.ToInt32(gameQuestions[questionNumber].CorrectChoice);
            if (tmpButton.Text == gameQuestions[questionNumber].Choice[correctChoice])
            {
                correctLabel.Text = "Correct";
                correctLabel.Visible = true;
                feedbackLabel.Visible = true;
                nextQuestion.Visible = true;
                scoreTrack++;
                choice1Button.Enabled = false;
                choice2Button.Enabled = false;
                choice3Button.Enabled = false;
                choice4Button.Enabled = false;
                questionNum++;

            }
            else
            {
                correctLabel.Text = "Incorrect";
                correctLabel.Visible = true;
                feedbackLabel.Visible = true;
                nextQuestion.Visible = true;
                choice1Button.Enabled = false;
                choice2Button.Enabled = false;
                choice3Button.Enabled = false;
                choice4Button.Enabled = false;
                questionNum++;
            }
        }

      //forth button selection, checks for correct anser
        private void choice4Button_Click(object sender, EventArgs e)
        {
            Button tmpButton = (Button)sender;
            int correctChoice = Convert.ToInt32(gameQuestions[questionNumber].CorrectChoice);
            if (tmpButton.Text == gameQuestions[questionNumber].Choice[correctChoice])
            {
                correctLabel.Text = "Correct";
                correctLabel.Visible = true;
                feedbackLabel.Visible = true;
                nextQuestion.Visible = true;
                scoreTrack++;
                choice1Button.Enabled = false;
                choice2Button.Enabled = false;
                choice3Button.Enabled = false;
                choice4Button.Enabled = false;
                questionNum++;

            }
            else
            {
                correctLabel.Text = "Incorrect";
                correctLabel.Visible = true;
                feedbackLabel.Visible = true;
                nextQuestion.Visible = true;
                choice1Button.Enabled = false;
                choice2Button.Enabled = false;
                choice3Button.Enabled = false;
                choice4Button.Enabled = false;
                questionNum++;
            }
        }

        //moves to the next question
        private void nextQuestion_Click(object sender, EventArgs e)
        {
            if (questionNumber  == 2)
            {

                triviaPicture.Visible = false;
                //instead of next it will switch the button to results
                resultsLabel.Text = $"Score: {scoreTrack} / 3";
                resultsLabel.Visible = true;
                gameOverBox.Visible = true;
                exitButton.Visible = true;
                questNum.Visible = false;

            }
            else
            {
                questionNumber++;
                
                DisplayQuestion();
                if(questionNumber == 2)
                {
                    nextQuestion.Text = "Show Score";
                }
            }
        }

        //exits the game and stops the music
        private void exitButton_Click(object sender, EventArgs e)
        {
            themeSong.Stop();
            Close();
        }
    }
}
