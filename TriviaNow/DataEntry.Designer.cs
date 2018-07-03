namespace TriviaNow
{
    partial class DataEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewQuestion = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.correctChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.feedbackTextBox = new System.Windows.Forms.TextBox();
            this.choice4TextBox = new System.Windows.Forms.TextBox();
            this.choice3TextBox = new System.Windows.Forms.TextBox();
            this.choice2TextBox = new System.Windows.Forms.TextBox();
            this.choice1TextBox = new System.Windows.Forms.TextBox();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.correctChoiceLabel = new System.Windows.Forms.Label();
            this.choice4Label = new System.Windows.Forms.Label();
            this.choice3Label = new System.Windows.Forms.Label();
            this.choice2Label = new System.Windows.Forms.Label();
            this.choice1Label = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.NewQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewQuestion
            // 
            this.NewQuestion.Controls.Add(this.editButton);
            this.NewQuestion.Controls.Add(this.addButton);
            this.NewQuestion.Controls.Add(this.correctChoiceComboBox);
            this.NewQuestion.Controls.Add(this.feedbackTextBox);
            this.NewQuestion.Controls.Add(this.choice4TextBox);
            this.NewQuestion.Controls.Add(this.choice3TextBox);
            this.NewQuestion.Controls.Add(this.choice2TextBox);
            this.NewQuestion.Controls.Add(this.choice1TextBox);
            this.NewQuestion.Controls.Add(this.questionTextBox);
            this.NewQuestion.Controls.Add(this.feedbackLabel);
            this.NewQuestion.Controls.Add(this.correctChoiceLabel);
            this.NewQuestion.Controls.Add(this.choice4Label);
            this.NewQuestion.Controls.Add(this.choice3Label);
            this.NewQuestion.Controls.Add(this.choice2Label);
            this.NewQuestion.Controls.Add(this.choice1Label);
            this.NewQuestion.Controls.Add(this.questionLabel);
            this.NewQuestion.Location = new System.Drawing.Point(54, 45);
            this.NewQuestion.Name = "NewQuestion";
            this.NewQuestion.Size = new System.Drawing.Size(1186, 552);
            this.NewQuestion.TabIndex = 0;
            this.NewQuestion.TabStop = false;
            this.NewQuestion.Text = "Question Details";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(192, 478);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(196, 48);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add Question";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // correctChoiceComboBox
            // 
            this.correctChoiceComboBox.FormattingEnabled = true;
            this.correctChoiceComboBox.Location = new System.Drawing.Point(192, 355);
            this.correctChoiceComboBox.Name = "correctChoiceComboBox";
            this.correctChoiceComboBox.Size = new System.Drawing.Size(260, 33);
            this.correctChoiceComboBox.TabIndex = 14;
            // 
            // feedbackTextBox
            // 
            this.feedbackTextBox.Location = new System.Drawing.Point(192, 422);
            this.feedbackTextBox.Name = "feedbackTextBox";
            this.feedbackTextBox.Size = new System.Drawing.Size(931, 31);
            this.feedbackTextBox.TabIndex = 13;
            // 
            // choice4TextBox
            // 
            this.choice4TextBox.Location = new System.Drawing.Point(192, 294);
            this.choice4TextBox.Name = "choice4TextBox";
            this.choice4TextBox.Size = new System.Drawing.Size(260, 31);
            this.choice4TextBox.TabIndex = 11;
            // 
            // choice3TextBox
            // 
            this.choice3TextBox.Location = new System.Drawing.Point(192, 231);
            this.choice3TextBox.Name = "choice3TextBox";
            this.choice3TextBox.Size = new System.Drawing.Size(260, 31);
            this.choice3TextBox.TabIndex = 10;
            // 
            // choice2TextBox
            // 
            this.choice2TextBox.Location = new System.Drawing.Point(192, 172);
            this.choice2TextBox.Name = "choice2TextBox";
            this.choice2TextBox.Size = new System.Drawing.Size(260, 31);
            this.choice2TextBox.TabIndex = 9;
            // 
            // choice1TextBox
            // 
            this.choice1TextBox.Location = new System.Drawing.Point(192, 108);
            this.choice1TextBox.Name = "choice1TextBox";
            this.choice1TextBox.Size = new System.Drawing.Size(260, 31);
            this.choice1TextBox.TabIndex = 8;
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(192, 48);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(931, 31);
            this.questionTextBox.TabIndex = 7;
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(19, 422);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(107, 25);
            this.feedbackLabel.TabIndex = 6;
            this.feedbackLabel.Text = "Feedback";
            // 
            // correctChoiceLabel
            // 
            this.correctChoiceLabel.AutoSize = true;
            this.correctChoiceLabel.Location = new System.Drawing.Point(19, 355);
            this.correctChoiceLabel.Name = "correctChoiceLabel";
            this.correctChoiceLabel.Size = new System.Drawing.Size(155, 25);
            this.correctChoiceLabel.TabIndex = 5;
            this.correctChoiceLabel.Text = "Correct Choice";
            // 
            // choice4Label
            // 
            this.choice4Label.AutoSize = true;
            this.choice4Label.Location = new System.Drawing.Point(19, 294);
            this.choice4Label.Name = "choice4Label";
            this.choice4Label.Size = new System.Drawing.Size(97, 25);
            this.choice4Label.TabIndex = 4;
            this.choice4Label.Text = "Choice 4";
            // 
            // choice3Label
            // 
            this.choice3Label.AutoSize = true;
            this.choice3Label.Location = new System.Drawing.Point(19, 231);
            this.choice3Label.Name = "choice3Label";
            this.choice3Label.Size = new System.Drawing.Size(97, 25);
            this.choice3Label.TabIndex = 3;
            this.choice3Label.Text = "Choice 3";
            // 
            // choice2Label
            // 
            this.choice2Label.AutoSize = true;
            this.choice2Label.Location = new System.Drawing.Point(19, 172);
            this.choice2Label.Name = "choice2Label";
            this.choice2Label.Size = new System.Drawing.Size(97, 25);
            this.choice2Label.TabIndex = 2;
            this.choice2Label.Text = "Choice 2";
            // 
            // choice1Label
            // 
            this.choice1Label.AutoSize = true;
            this.choice1Label.Location = new System.Drawing.Point(19, 108);
            this.choice1Label.Name = "choice1Label";
            this.choice1Label.Size = new System.Drawing.Size(97, 25);
            this.choice1Label.TabIndex = 1;
            this.choice1Label.Text = "Choice 1";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(19, 51);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(98, 25);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Question";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(970, 478);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(153, 48);
            this.editButton.TabIndex = 16;
            this.editButton.Text = "Edit Question";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // DataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 640);
            this.Controls.Add(this.NewQuestion);
            this.Name = "DataEntry";
            this.Text = "DataEntry";
            this.Load += new System.EventHandler(this.DataEntry_Load);
            this.NewQuestion.ResumeLayout(false);
            this.NewQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NewQuestion;
        private System.Windows.Forms.TextBox feedbackTextBox;
        private System.Windows.Forms.TextBox choice4TextBox;
        private System.Windows.Forms.TextBox choice3TextBox;
        private System.Windows.Forms.TextBox choice2TextBox;
        private System.Windows.Forms.TextBox choice1TextBox;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.Label correctChoiceLabel;
        private System.Windows.Forms.Label choice4Label;
        private System.Windows.Forms.Label choice3Label;
        private System.Windows.Forms.Label choice2Label;
        private System.Windows.Forms.Label choice1Label;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.ComboBox correctChoiceComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
    }
}