using GeniyIdiotConsoleApp;
using User = GeniyIdiotConsoleApp.User;

namespace GeniyIdiotWinForm
{
    public partial class MainForm : Form
    {

        private List<Question> questions;
        private int numberCurrentQuestions = 1;
        private User user;
        private int randomIndex;
        private int questionsCount;
        private int rightAnswersCount = 0;
        private int userAnswer;
        private int rightAnswer;
        private string userName;
        public MainForm(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

            user = new User(userName);

            questions = QuestionStorage.GetQuestions();
            questionsCount = questions.Count;

            ShowNextQuestions();
        }

        public void ShowNextQuestions()
        {

            var random = new Random();
            randomIndex = random.Next(0, questions.Count);

            questionNumberLabel.Text = "Вопрос №" + numberCurrentQuestions;
            questionTextLabel.Text = questions[randomIndex].Text;
            numberCurrentQuestions++;

            rightAnswer = questions[randomIndex].Answer;

            questions.Remove(questions[randomIndex]);
            UserAnswerNumericUpDown.Refresh();

        }
        private void NextQuestionButton_Click_1(object sender, EventArgs e)
        {

            userAnswer = (int)UserAnswerNumericUpDown.Value;

            if (userAnswer == rightAnswer)
            {
                rightAnswersCount++;
            }
            if (questions.Count == 0)
            {
                user.Diagnose = UserStorage.GetDiagnoses(questionsCount, rightAnswersCount);

                MessageBox.Show($"Уважаемый {user.Name}, количество правильных ответов - {rightAnswersCount}. Ваш диагноз - {user.Diagnose}");

                UserStorage.Save(user);
                Close();

                return;
            }

            ShowNextQuestions();
        }
    }
}
