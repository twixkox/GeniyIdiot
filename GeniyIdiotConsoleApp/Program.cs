using System;
using System.IO;
using System.Text;

namespace GeniyIdiotConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var isRepeatProgramm = true;
            var userStorage = new UserStorage();

            Console.WriteLine("Здравствуйте, введите ваши ФИО.");

            var user = new User(Console.ReadLine(), 0, string.Empty);

            while (isRepeatProgramm)
            {
                user.RightAnswersCount = 0;

                var questions = QuestionStorage.GetQuestions();
                var questionsCount = questions.Count;

                for (int i = 0; i < questionsCount; i++)
                {
                    var randomIndex = random.Next(0, questions.Count);
                    Console.WriteLine("Вопрос №" + (i + 1));
                    Console.WriteLine(questions[randomIndex].Text);

                    var userAnswer = Console.ReadLine();

                    var resultUserAnswer = TryGetUserAnswer(userAnswer);

                    var rightAnswer = questions[randomIndex].Answer;

                    if (resultUserAnswer == rightAnswer)
                    {
                        user.RightAnswersCount++;
                    }

                    questions.RemoveAt(randomIndex);
                }
                user.Diagnose = UserStorage.GetDiagnoses(questionsCount, user.RightAnswersCount);

                Console.WriteLine("Количество правильных ответов " + user.RightAnswersCount);

                Console.WriteLine($"Уважаемый(ая) {user.Name}, ваш диагноз {user.Diagnose}.");

                UserStorage.Save(user);
                ShowStatistic();
                isRepeatProgramm = IsRepeat();
                UserAddQuestions();
                UserRemoveQuestions();
            }
        }
        static bool IsGetYesNoInput()
        {
            var inputUserAnswer = Console.ReadLine().ToLower();

            while (inputUserAnswer != "y" && inputUserAnswer != "n")
            {
                Console.WriteLine("Введите Y или N");

                inputUserAnswer = Console.ReadLine().ToLower();
            }

            return inputUserAnswer == "y";
        }
        static bool IsRepeat()
        {
            Console.WriteLine("Хотели бы вы повторить тест? Y/N");

            return IsGetYesNoInput();
        }

        static void ShowStatistic()
        {
            Console.WriteLine("Хотели бы вы просмотреть статистику? Y/N");

            if (!IsGetYesNoInput())
            {
                return;
            }

            var users = UserStorage.GetAll();

            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"{users[i].Name}, {users[i].RightAnswersCount}, {users[i].Diagnose}");
            }
        }
        static int TryGetUserAnswer(string userAnswer)
        {
            var resultUserAnswer = 0;

            while (!int.TryParse(userAnswer, out resultUserAnswer))
            {
                Console.WriteLine("Введите пожалуйста число");
                userAnswer = Console.ReadLine();
            }

            return resultUserAnswer;
        }

        static void UserAddQuestions()
        {

            Console.WriteLine("Хотели-бы вы добавить свой вопрос?");

            if (!IsGetYesNoInput())
            {
                return;
            }

            Console.WriteLine("Введите вопрос:");
            var userQuestion = Console.ReadLine();

            while (string.IsNullOrEmpty(userQuestion))
            {
                Console.WriteLine("Вопрос не может быть пустым");
                userQuestion = Console.ReadLine();
            }

            Console.WriteLine("Введите ответ:");
            var userQuestionAnswer = Console.ReadLine();
            var resultQuestionAnswer = TryGetUserAnswer(userQuestionAnswer);

            QuestionStorage.Add(userQuestion, resultQuestionAnswer);

        }

        static void UserRemoveQuestions()
        {
            var questions = QuestionStorage.GetQuestions();
            Console.WriteLine("Хотите удалить вопрос?");

            if (!IsGetYesNoInput())
            {
                return;
            }

            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine("Выберите номер вопроса для удаления");
                Console.WriteLine($"{i + 1}. {questions[i].Text}");
            }
            var removeQuestionNumber = Console.ReadLine();
            var deleteQuestionNumber = TryGetUserAnswer(removeQuestionNumber);

            var deleteQuestions = questions[deleteQuestionNumber - 1];

            QuestionStorage.Remove(deleteQuestions);
        }
    }
}
