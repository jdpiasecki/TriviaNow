//Jeff Piasecki CIS 345 Project 12:00
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaNow
{
    public partial class QuestionDetails : Form
    {
        DataEntry dataform;
        BindingList<Question> questonlist;
        private string saveName;
        Game newGame;
        List<Question> gameQuestions;

        public QuestionDetails()
        {
            InitializeComponent();
            questonlist = new BindingList<Question>();
        }

        private void DataForm_NewQuestionCreated(object sender, EventArgs e)
        {
            DataEntryEventArgs tmpArgs = new DataEntryEventArgs(null);

            //downcast to add the new question to the listbox
            if (e is DataEntryEventArgs)
            {
                tmpArgs = (DataEntryEventArgs)e;
                Question tmpQuestion = tmpArgs.Question;
                questonlist.Add(tmpQuestion);

            }
        }

        //event handler for the new NewQuestionCreated event
        private void SetEventHandler()
        {
            dataform.NewQuestionCreated += new EventHandler(this.DataForm_NewQuestionCreated);
        }

        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataform = new DataEntry();
            dataform.Show();
            SetEventHandler();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            questionListBox.DataSource = questonlist;
        }

        //saves file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";

            //dialog box allows the user to name the file
            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                saveName = fileName;
            }

            try
            {
                FileStream file = new FileStream(saveFileDialog1.FileName, FileMode.Create,
                    FileAccess.Write);

                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, questonlist);
                file.Close();
                statusLabel.Text = "Save Successful";
            }
            catch (Exception)
            {
                statusLabel.Text = "Save Not Successful";
            }
        }

        //opens file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                try
                {
                    //dialog box allows you select the file to open
                    openFileDialog1.FileName = "";
                    openFileDialog1.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
                    DialogResult result = openFileDialog1.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        string fileName = openFileDialog1.FileName;
                        saveName = fileName;

                        FileStream file = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                        BinaryFormatter bf = new BinaryFormatter();

                        questonlist = (BindingList<Question>)bf.Deserialize(file);
                        questionListBox.DataSource = questonlist;
                        statusLabel.Text = "Data File Loaded";
                        timer1.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    statusLabel.Text = "Data File Load Not Successful";
                    timer1.Enabled = true;
                }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            statusLabel.Text = "Ready";
        }

        //exits the program and allows the user to save
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAndExit();
            
            
        }

        //method used in the exit process to save the file
        private void SaveAndExit()
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";
            string fileName = null;

            if (string.IsNullOrEmpty(saveName))
            {
                DialogResult result = saveFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    fileName = saveFileDialog1.FileName;
                }
                else
                {
                    return;
                }
            }
            else
            {
                fileName = saveName;
            }

            try
            {
                FileStream file = new FileStream(fileName, FileMode.Create,
                    FileAccess.Write);

                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, questonlist);
                file.Close();
                statusLabel.Text = "Save Successful";
                timer1.Enabled = true;
            }
            catch (Exception)
            {
                statusLabel.Text = "Save Not Successful";
                timer1.Enabled = true;
            }

            System.Environment.Exit(0);
        }

        // starts the game and creates 3 random question
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random randomGenerator;

            int index;
            Question tmpQuestion;
            randomGenerator = new Random();
            gameQuestions = new List<Question>();

            int i = 0;
            //generates the 3 questions
            while (i < 3)
            {
                index = randomGenerator.Next(0, questonlist.Count);
                tmpQuestion = questonlist.ElementAt(index);
                //checks to see if the tmpquestion is already in the question list
                if (!gameQuestions.Contains(tmpQuestion))
                {
                    gameQuestions.Add(tmpQuestion);
                    i++;
                }
                
            }
            newGame = new Game(gameQuestions);
            newGame.Show();
        }

        // allows for the editing of the question data
        private void editQuestionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(questionListBox.SelectedItem != null)
            {
                
                Question tmpQuestion;
                tmpQuestion = (Question)questionListBox.SelectedItem;
                dataform = new DataEntry(tmpQuestion);
                dataform.QuestionUpdated += new EventHandler(UpdateForm_QuestionUpdated);
                dataform.Show();
            }
        }

        //updates the question and displays the question updated in the status label
        private void UpdateForm_QuestionUpdated(object sennder, EventArgs e)
        {
            if(e is DataEntryEventArgs)
            {
                DataEntryEventArgs tmpArgs = (DataEntryEventArgs)e;
                Question tmpQuestion = tmpArgs.Question;
                statusLabel.Text = $"Question Updated - {tmpQuestion.MyQuestion}";
                timer1.Enabled = true;

                questonlist.ResetBindings();
            }
        }

        // allows the user to delete a question
        private void deleteQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question tmpQuestion;

            tmpQuestion = (Question)questionListBox.SelectedItem;

            questonlist.Remove(tmpQuestion);
        }

        //searches the text box for a particular question 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var searchDataText = textBox1.Text;
            questionListBox.DataSource = null;
            if(string.IsNullOrEmpty(searchDataText) || textBox1.Equals("Search Question"))
            {
                questionListBox.DataSource = questonlist;
            }
            else
            {
                var searchDataList = new BindingList<Question>();
                foreach(var question in questonlist)
                {
                    if (question.MyQuestion.ToUpper().Contains(searchDataText.ToUpper())
                        || question.Choice.Any(x => x.ToUpper().Contains(searchDataText.ToUpper()))
                        || question.Feedback.ToUpper().Contains(searchDataText.ToUpper()))
                    {
                        searchDataList.Add(question);
                    }
                    questionListBox.DataSource = searchDataList;
                }
            }
        }
    }
    }
    

