namespace GeniyIdiotWinForm
{
    partial class RemoveQuestionForm
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
            removeQuestionTextLabel = new Label();
            removeButton = new Button();
            listBoxQuestions = new ListBox();
            SuspendLayout();
            // 
            // removeQuestionTextLabel
            // 
            removeQuestionTextLabel.AutoSize = true;
            removeQuestionTextLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            removeQuestionTextLabel.Location = new Point(453, 31);
            removeQuestionTextLabel.Margin = new Padding(6, 0, 6, 0);
            removeQuestionTextLabel.Name = "removeQuestionTextLabel";
            removeQuestionTextLabel.Size = new Size(346, 30);
            removeQuestionTextLabel.TabIndex = 0;
            removeQuestionTextLabel.Text = "Выделите вопрос для удаления.";
            // 
            // removeButton
            // 
            removeButton.Location = new Point(531, 289);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(192, 84);
            removeButton.TabIndex = 4;
            removeButton.Text = "Удалить";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // listBoxQuestions
            // 
            listBoxQuestions.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            listBoxQuestions.FormattingEnabled = true;
            listBoxQuestions.Location = new Point(266, 98);
            listBoxQuestions.Name = "listBoxQuestions";
            listBoxQuestions.Size = new Size(691, 130);
            listBoxQuestions.TabIndex = 5;
            // 
            // RemoveQuestionForm
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1201, 435);
            Controls.Add(listBoxQuestions);
            Controls.Add(removeButton);
            Controls.Add(removeQuestionTextLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(6);
            Name = "RemoveQuestionForm";
            Text = "RemoveQuestion";
            Load += RemoveQuestion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label removeQuestionTextLabel;
        private Button removeButton;
        private ListBox listBoxQuestions;
    }
}