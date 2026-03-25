using Newtonsoft.Json;

namespace GeniyIdiotConsoleApp
{
    public class QuestionStorage
    {
        private const string fileName = "QuestionsStorage.json";
        private static List<Question> questions = new List<Question>();
        public static List<Question> GetQuestions()
        {
            if (File.Exists(fileName))
            {
                var fileRead = FileProvider.Read(fileName);
                questions = JsonConvert.DeserializeObject<List<Question>>(fileRead);
            }
            else
            {
                new List<Question>();
                Add("Сколько будет два плюс два умноженное на два?", 6);
                Add("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9);
                Add("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25);
                Add("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60);
                Add("Пять свечей горело, две потухли. Сколько свечей осталось?", 2);
                Save(questions);
            }
            return questions;
        }

        public static void Add(string userQuestion, int userQuestionAnswer)
        {
            questions.Add(new Question(userQuestion, userQuestionAnswer));
            Save(questions);
        }

        private static void Save(List<Question> questions)
        {
            var jsonDataQuestions = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileProvider.Replace(jsonDataQuestions, fileName);
        }

        public static void Remove(Question deleteQuestions)
        {
            var questions = QuestionStorage.GetQuestions();

            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].Text == deleteQuestions.Text)
                {
                    questions.RemoveAt(i);
                    break;
                }
            }
            FileProvider.Clear(fileName);
            questions.Remove(deleteQuestions);
            foreach (var question in questions)
            {
                var saveQuestions = questions;
                Save(saveQuestions);
            }
        }
    }
}
