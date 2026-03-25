namespace GeniyIdiotWinForm
{
    partial class AddQuestionForm
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
            addQuestionButton = new Button();
            addQuestionsLabel = new Label();
            addQuestionTextBox = new TextBox();
            addAnswerQuestion = new Label();
            addAnswerTextBox = new TextBox();
            SuspendLayout();
            // 
            // addQuestionButton
            // 
            addQuestionButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addQuestionButton.Location = new Point(319, 332);
            addQuestionButton.Name = "addQuestionButton";
            addQuestionButton.Size = new Size(221, 77);
            addQuestionButton.TabIndex = 0;
            addQuestionButton.Text = "Добавить";
            addQuestionButton.UseVisualStyleBackColor = true;
            addQuestionButton.Click += addQuestionButton_Click;
            // 
            // addQuestionsLabel
            // 
            addQuestionsLabel.AutoSize = true;
            addQuestionsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addQuestionsLabel.Location = new Point(328, 56);
            addQuestionsLabel.Name = "addQuestionsLabel";
            addQuestionsLabel.Size = new Size(203, 32);
            addQuestionsLabel.TabIndex = 1;
            addQuestionsLabel.Text = "Введите вопрос";
            // 
            // addQuestionTextBox
            // 
            addQuestionTextBox.Location = new Point(227, 130);
            addQuestionTextBox.Name = "addQuestionTextBox";
            addQuestionTextBox.Size = new Size(409, 23);
            addQuestionTextBox.TabIndex = 2;
            addQuestionTextBox.TextChanged += addQuestionTextBox_TextChanged;
            // 
            // addAnswerQuestion
            // 
            addAnswerQuestion.AutoSize = true;
            addAnswerQuestion.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addAnswerQuestion.Location = new Point(338, 192);
            addAnswerQuestion.Name = "addAnswerQuestion";
            addAnswerQuestion.Size = new Size(181, 32);
            addAnswerQuestion.TabIndex = 3;
            addAnswerQuestion.Text = "Введите ответ";
            // 
            // addAnswerTextBox
            // 
            addAnswerTextBox.Location = new Point(227, 259);
            addAnswerTextBox.Name = "addAnswerTextBox";
            addAnswerTextBox.Size = new Size(409, 23);
            addAnswerTextBox.TabIndex = 4;
            // 
            // AddQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(addAnswerTextBox);
            Controls.Add(addAnswerQuestion);
            Controls.Add(addQuestionTextBox);
            Controls.Add(addQuestionsLabel);
            Controls.Add(addQuestionButton);
            Name = "AddQuestionForm";
            Text = "addQuestion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button addQuestionButton;
        private Label addQuestionsLabel;
        public TextBox addQuestionTextBox;
        private Label addAnswerQuestion;
        public TextBox addAnswerTextBox;
    }
}