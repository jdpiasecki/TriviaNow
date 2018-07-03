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

namespace TriviaNow
{


    public partial class DataEntry : Form
    {
        //event to be raised when a new question is created
        public event EventHandler NewQuestionCreated;

        public event EventHandler QuestionUpdated;

        public Question Question;

        public List<string> choice;

        public DataEntry()
        {
            InitializeComponent();
            choice = new List<string>()
            {
                "A", "B", "C", "D"
            };
        }

        //constructor used to display the data in the details
        public DataEntry(Question q)
        {
            InitializeComponent();
            this.Question = q;
            choice = new List<string>()
            {
                "A", "B", "C", "D"
            };
        }

        //adds a question to the question list box
        private void addButton_Click(object sender, EventArgs e)
        {
            if (questionTextBox.Text == string.Empty || choice1TextBox.Text == string.Empty ||
                choice2TextBox.Text == string.Empty || choice3TextBox.Text == string.Empty ||
                choice4TextBox.Text == string.Empty)
            {
                MessageBox.Show("Please make sure all fields are entered");
                return;
            }

            //new data in a Question object
            // put question data in a DataEntryEventArgs object
            Question tmpQuestion = new Question(questionTextBox.Text, choice1TextBox.Text, choice2TextBox.Text,
                choice3TextBox.Text, choice4TextBox.Text, feedbackTextBox.Text, correctChoiceComboBox.SelectedIndex.ToString());
            DataEntryEventArgs tmpArgs = new DataEntryEventArgs(tmpQuestion);

            //clears the data in the text box so a new question can be added
            if (NewQuestionCreated != null)
            {
                NewQuestionCreated(this, tmpArgs);
                questionTextBox.Clear();
                choice1TextBox.Clear();
                choice2TextBox.Clear();
                choice3TextBox.Clear();
                choice4TextBox.Clear();
                correctChoiceComboBox.SelectedItem = 1;
                feedbackTextBox.Clear();
                questionTextBox.Focus();

            }
        }

        //brings up the form for editing a question
        private void DataEntry_Load(object sender, EventArgs e)
        {
            correctChoiceComboBox.DataSource = choice;
            addButton.Visible = true;
            editButton.Visible = false;
            if (Question != null)
            {
                this.Text = "Edit Question";
                questionTextBox.Text = Question.MyQuestion;
                choice1TextBox.Text = Question.Choice[0];
                choice2TextBox.Text = Question.Choice[1];
                choice3TextBox.Text = Question.Choice[2];
                choice4TextBox.Text = Question.Choice[3];
                correctChoiceComboBox.SelectedIndex = Convert.ToInt32(Question.CorrectChoice);
                feedbackTextBox.Text = Question.Feedback;
                addButton.Visible = false;
                editButton.Visible = true;
            }
        }

        //edits the question
        private void editButton_Click(object sender, EventArgs e)
        {
            Question tmpQuestion = new Question(questionTextBox.Text, choice1TextBox.Text, choice2TextBox.Text,
                choice3TextBox.Text, choice4TextBox.Text, feedbackTextBox.Text, correctChoiceComboBox.SelectedIndex.ToString());

            Question.MyQuestion = questionTextBox.Text;
            Question.Choice[0] = choice1TextBox.Text;
            Question.Choice[1] = choice2TextBox.Text;
            Question.Choice[2] = choice3TextBox.Text;
            Question.Choice[3] = choice4TextBox.Text;
            Question.Feedback = feedbackTextBox.Text;
            Question.CorrectChoice = correctChoiceComboBox.SelectedIndex.ToString();

            DataEntryEventArgs tmpArgs = new DataEntryEventArgs(tmpQuestion);

            if(QuestionUpdated != null)
                QuestionUpdated(this, tmpArgs);
            this.Close();
            

            

        }
    }
}
