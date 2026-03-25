
using GeniyIdiotConsoleApp;

namespace GeniyIdiotWinForm
{
    partial class startForm
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
            startTestButton = new Button();
            userNameTextBox = new TextBox();
            startLabel = new Label();
            ShowStatisticButton = new Button();
            addQuestionButton = new Button();
            removeQuestionButton = new Button();
            resetStatisticButton = new Button();
            exitProgramm = new Button();
            SuspendLayout();
            // 
            // startTestButton
            // 
            startTestButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startTestButton.Location = new Point(231, 169);
            startTestButton.Name = "startTestButton";
            startTestButton.Size = new Size(409, 99);
            startTestButton.TabIndex = 0;
            startTestButton.Text = "Начать тест";
            startTestButton.UseVisualStyleBackColor = true;
            startTestButton.Click += startTestButton_Click;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(231, 88);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(409, 23);
            userNameTextBox.TabIndex = 1;
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startLabel.Location = new Point(231, 32);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(409, 32);
            startLabel.TabIndex = 2;
            startLabel.Text = "Здравствуйте,введите ваши ФИО";
            // 
            // ShowStatisticButton
            // 
            ShowStatisticButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ShowStatisticButton.Location = new Point(13, 83);
            ShowStatisticButton.Name = "ShowStatisticButton";
            ShowStatisticButton.Size = new Size(145, 55);
            ShowStatisticButton.TabIndex = 3;
            ShowStatisticButton.Text = "Просмотреть статистику";
            ShowStatisticButton.UseVisualStyleBackColor = true;
            ShowStatisticButton.Click += ShowStatisticButton_Click;
            // 
            // addQuestionButton
            // 
            addQuestionButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addQuestionButton.Location = new Point(13, 144);
            addQuestionButton.Name = "addQuestionButton";
            addQuestionButton.Size = new Size(144, 55);
            addQuestionButton.TabIndex = 4;
            addQuestionButton.Text = "Добавить вопрос";
            addQuestionButton.UseVisualStyleBackColor = true;
            addQuestionButton.Click += addQuestionButton_Click;
            // 
            // removeQuestionButton
            // 
            removeQuestionButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            removeQuestionButton.Location = new Point(14, 205);
            removeQuestionButton.Name = "removeQuestionButton";
            removeQuestionButton.Size = new Size(144, 55);
            removeQuestionButton.TabIndex = 5;
            removeQuestionButton.Text = "Удалить вопрос";
            removeQuestionButton.UseVisualStyleBackColor = true;
            removeQuestionButton.Click += removeQuestionButton_Click;
            // 
            // resetStatisticButton
            // 
            resetStatisticButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            resetStatisticButton.Location = new Point(11, 266);
            resetStatisticButton.Name = "resetStatisticButton";
            resetStatisticButton.Size = new Size(146, 55);
            resetStatisticButton.TabIndex = 6;
            resetStatisticButton.Text = "Сбросить статистику";
            resetStatisticButton.UseVisualStyleBackColor = true;
            resetStatisticButton.Click += resetStatisticButton_Click;
            // 
            // exitProgramm
            // 
            exitProgramm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exitProgramm.Location = new Point(364, 386);
            exitProgramm.Name = "exitProgramm";
            exitProgramm.Size = new Size(148, 55);
            exitProgramm.TabIndex = 7;
            exitProgramm.Text = "Выйти из приложения";
            exitProgramm.UseVisualStyleBackColor = true;
            exitProgramm.Click += exitProgramm_Click;
            // 
            // startForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(863, 480);
            Controls.Add(exitProgramm);
            Controls.Add(resetStatisticButton);
            Controls.Add(removeQuestionButton);
            Controls.Add(addQuestionButton);
            Controls.Add(ShowStatisticButton);
            Controls.Add(startLabel);
            Controls.Add(userNameTextBox);
            Controls.Add(startTestButton);
            Name = "startForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button startTestButton;
        private TextBox userNameTextBox;
        private Label startLabel;
        private Button ShowStatisticButton;
        private Button addQuestionButton;
        private Button removeQuestionButton;
        private Button resetStatisticButton;
        private Button exitProgramm;
    }
}