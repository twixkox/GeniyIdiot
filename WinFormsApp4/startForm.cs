using GeniyIdiotConsoleApp;
using Newtonsoft.Json;
namespace GeniyIdiotWinForm
{

    public partial class startForm : Form
    {
        public startForm()
        {
            
            var questions = QuestionStorage.GetQuestions();
            InitializeComponent();
        }

        private void startTestButton_Click(object sender, EventArgs e)
        {
            new MainForm(userNameTextBox.Text).ShowDialog();
        }

        private void ShowStatisticButton_Click(object sender, EventArgs e)
        {
            var userResults = new UserResultForm();
            userResults.ShowDialog();
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            var userQuestion = new AddQuestionForm();
            userQuestion.ShowDialog();            
        }

        private void removeQuestionButton_Click(object sender, EventArgs e)
        {
            var userRemoveQuestion = new RemoveQuestionForm();
            userRemoveQuestion.ShowDialog();
        }

        private void resetStatisticButton_Click(object sender, EventArgs e)
        {
            FileProvider.Delete("UserData.json");
            MessageBox.Show("Статистика сброшена");
        }

        private void exitProgramm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
