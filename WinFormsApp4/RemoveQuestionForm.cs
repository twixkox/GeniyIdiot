using GeniyIdiotConsoleApp;

namespace GeniyIdiotWinForm
{
    public partial class RemoveQuestionForm : Form
    {
        List<Question> questions;
        public RemoveQuestionForm()
        {
            InitializeComponent();
        }

        private void RemoveQuestion_Load(object sender, EventArgs e)
        {
            questions = QuestionStorage.GetQuestions();
            var questionsNumber = 1;

            listBoxQuestions.Items.Clear();

            for (int i = 0; i < questions.Count; i++)
            {
                listBoxQuestions.Items.Add($"№ - {questionsNumber}. {questions[i].Text}");
                questionsNumber++;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
        
            var selectIndex = listBoxQuestions.SelectedIndex;
            var removeQuestion = questions[selectIndex];

            QuestionStorage.Remove(removeQuestion);

            MessageBox.Show($"Вопрос удален.");
            Close();
        }
    }
}
