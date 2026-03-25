namespace GeniyIdiotConsoleApp
{
    public class User
    {
        public string Name;
        public int RightAnswersCount;
        public string Diagnose;

        public User(string name, int rightAnswersCount, string diagnose)
        {
            Name = name;
            RightAnswersCount = rightAnswersCount;
            Diagnose = diagnose;
        }

        public User(string name)
        {
            Name = name;
        }

        public User() { }
    }
}

