namespace GeniyIdiotWinForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            questionTextLabel = new Label();
            questionNumberLabel = new Label();
            NextQuestionButton = new Button();
            UserAnswerNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)UserAnswerNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Location = new Point(370, 113);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(0, 15);
            questionTextLabel.TabIndex = 0;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            questionNumberLabel.Location = new Point(370, 70);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(104, 25);
            questionNumberLabel.TabIndex = 1;
            questionNumberLabel.Text = "Вопрос №";
            // 
            // NextQuestionButton
            // 
            NextQuestionButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NextQuestionButton.Location = new Point(302, 307);
            NextQuestionButton.Name = "NextQuestionButton";
            NextQuestionButton.Size = new Size(241, 99);
            NextQuestionButton.TabIndex = 3;
            NextQuestionButton.Text = "Продолжить";
            NextQuestionButton.UseVisualStyleBackColor = true;
            NextQuestionButton.Click += NextQuestionButton_Click_1;
            // 
            // UserAnswerNumericUpDown
            // 
            UserAnswerNumericUpDown.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            UserAnswerNumericUpDown.Location = new Point(302, 153);
            UserAnswerNumericUpDown.Name = "UserAnswerNumericUpDown";
            UserAnswerNumericUpDown.Size = new Size(241, 29);
            UserAnswerNumericUpDown.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(UserAnswerNumericUpDown);
            Controls.Add(NextQuestionButton);
            Controls.Add(questionNumberLabel);
            Controls.Add(questionTextLabel);
            Name = "MainForm";
            Text = "Form1";
            Load += mainForm_Load;
            ((System.ComponentModel.ISupportInitialize)UserAnswerNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questionTextLabel;
        private Label questionNumberLabel;
        private Button NextQuestionButton;
        private NumericUpDown UserAnswerNumericUpDown;
    }
}
