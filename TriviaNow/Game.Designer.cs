namespace TriviaNow
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.questionLabel = new System.Windows.Forms.Label();
            this.choice1Button = new System.Windows.Forms.Button();
            this.choice2Button = new System.Windows.Forms.Button();
            this.choice3Button = new System.Windows.Forms.Button();
            this.choice4Button = new System.Windows.Forms.Button();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.Label();
            this.nextQuestion = new System.Windows.Forms.Button();
            this.gameOverBox = new System.Windows.Forms.PictureBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.triviaPicture = new System.Windows.Forms.PictureBox();
            this.questNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triviaPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(87, 172);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(70, 25);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "label1";
            // 
            // choice1Button
            // 
            this.choice1Button.Location = new System.Drawing.Point(92, 239);
            this.choice1Button.Name = "choice1Button";
            this.choice1Button.Size = new System.Drawing.Size(292, 58);
            this.choice1Button.TabIndex = 1;
            this.choice1Button.Text = "button1";
            this.choice1Button.UseVisualStyleBackColor = true;
            this.choice1Button.Click += new System.EventHandler(this.choice1Button_Click);
            // 
            // choice2Button
            // 
            this.choice2Button.Location = new System.Drawing.Point(92, 348);
            this.choice2Button.Name = "choice2Button";
            this.choice2Button.Size = new System.Drawing.Size(292, 58);
            this.choice2Button.TabIndex = 2;
            this.choice2Button.Text = "button2";
            this.choice2Button.UseVisualStyleBackColor = true;
            this.choice2Button.Click += new System.EventHandler(this.choice2Button_Click);
            // 
            // choice3Button
            // 
            this.choice3Button.Location = new System.Drawing.Point(92, 444);
            this.choice3Button.Name = "choice3Button";
            this.choice3Button.Size = new System.Drawing.Size(292, 58);
            this.choice3Button.TabIndex = 3;
            this.choice3Button.Text = "button3";
            this.choice3Button.UseVisualStyleBackColor = true;
            this.choice3Button.Click += new System.EventHandler(this.choice3Button_Click);
            // 
            // choice4Button
            // 
            this.choice4Button.Location = new System.Drawing.Point(92, 547);
            this.choice4Button.Name = "choice4Button";
            this.choice4Button.Size = new System.Drawing.Size(292, 58);
            this.choice4Button.TabIndex = 4;
            this.choice4Button.Text = "button4";
            this.choice4Button.UseVisualStyleBackColor = true;
            this.choice4Button.Click += new System.EventHandler(this.choice4Button_Click);
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(87, 647);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(70, 25);
            this.feedbackLabel.TabIndex = 5;
            this.feedbackLabel.Text = "label2";
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Location = new System.Drawing.Point(505, 348);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(70, 25);
            this.correctLabel.TabIndex = 6;
            this.correctLabel.Text = "label1";
            // 
            // nextQuestion
            // 
            this.nextQuestion.Location = new System.Drawing.Point(816, 547);
            this.nextQuestion.Name = "nextQuestion";
            this.nextQuestion.Size = new System.Drawing.Size(195, 58);
            this.nextQuestion.TabIndex = 7;
            this.nextQuestion.Text = "Next Question";
            this.nextQuestion.UseVisualStyleBackColor = true;
            this.nextQuestion.Click += new System.EventHandler(this.nextQuestion_Click);
            // 
            // gameOverBox
            // 
            this.gameOverBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameOverBox.BackgroundImage")));
            this.gameOverBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameOverBox.Location = new System.Drawing.Point(-10, -1);
            this.gameOverBox.Name = "gameOverBox";
            this.gameOverBox.Size = new System.Drawing.Size(1133, 688);
            this.gameOverBox.TabIndex = 8;
            this.gameOverBox.TabStop = false;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(381, 630);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(70, 25);
            this.resultsLabel.TabIndex = 9;
            this.resultsLabel.Text = "label1";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(925, 631);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(157, 41);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // triviaPicture
            // 
            this.triviaPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("triviaPicture.BackgroundImage")));
            this.triviaPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.triviaPicture.Location = new System.Drawing.Point(543, -1);
            this.triviaPicture.Name = "triviaPicture";
            this.triviaPicture.Size = new System.Drawing.Size(580, 177);
            this.triviaPicture.TabIndex = 11;
            this.triviaPicture.TabStop = false;
            // 
            // questNum
            // 
            this.questNum.AutoSize = true;
            this.questNum.Location = new System.Drawing.Point(92, 36);
            this.questNum.Name = "questNum";
            this.questNum.Size = new System.Drawing.Size(70, 25);
            this.questNum.TabIndex = 12;
            this.questNum.Text = "label1";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 707);
            this.Controls.Add(this.questNum);
            this.Controls.Add(this.triviaPicture);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.gameOverBox);
            this.Controls.Add(this.nextQuestion);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.choice4Button);
            this.Controls.Add(this.choice3Button);
            this.Controls.Add(this.choice2Button);
            this.Controls.Add(this.choice1Button);
            this.Controls.Add(this.questionLabel);
            this.Name = "Game";
            this.Text = "Trivia Now!!!";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameOverBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triviaPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button choice1Button;
        private System.Windows.Forms.Button choice2Button;
        private System.Windows.Forms.Button choice3Button;
        private System.Windows.Forms.Button choice4Button;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Button nextQuestion;
        private System.Windows.Forms.PictureBox gameOverBox;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox triviaPicture;
        private System.Windows.Forms.Label questNum;
    }
}