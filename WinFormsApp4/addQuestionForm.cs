using GeniyIdiotConsoleApp;

namespace GeniyIdiotWinForm
{
    public partial class AddQuestionForm : Form
    {

        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void addQuestionTextBox_TextChanged(object sender, EventArgs e)
        {
            var inputTextQuestion = addQuestionTextBox.Text;

            if (string.IsNullOrEmpty(inputTextQuestion))
            {
                MessageBox.Show("Вопрос не может быть пустым");
            }
        }
        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            QuestionStorage.Add(addQuestionTextBox.Text, Convert.ToInt32(addAnswerTextBox.Text));
            MessageBox.Show($"Ваш вопрос - {addQuestionTextBox.Text}. Ответ - {addAnswerTextBox.Text}. Успешно записан");

            Close();
        }
    }
}
