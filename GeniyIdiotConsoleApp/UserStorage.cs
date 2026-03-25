using Newtonsoft.Json;

namespace GeniyIdiotConsoleApp
{
    public class UserStorage
    {
        private const string fileName = "UserData.json";
        public static void Save(User user)
        {
            var userResults = GetAll();
            userResults.Add(user);
            var jsonData = JsonConvert.SerializeObject(userResults, Formatting.Indented);
            FileProvider.Replace(jsonData, fileName);
        }


        public static List<User> GetAll()
        {
            if (!File.Exists(fileName))
            {
                return new List<User>();
            }

            var fileRead = FileProvider.Read(fileName);

            var usersGet = JsonConvert.DeserializeObject<List<User>>(fileRead);

            return usersGet;
        }

        public static string GetDiagnoses(int questionsCount, int rightAnswersCount)
        {
            var scorePercent = (double)rightAnswersCount / questionsCount * 100;
            switch (scorePercent)
            {
                case > 80:
                    return "Гений";

                case > 60:
                    return "Талант";

                case > 40:
                    return "Нормальный";

                case > 20:
                    return "Дурак";

                case > 0:
                    return "Идиот";

                default:
                    return "Кретин";
            }
        }
    }
}

