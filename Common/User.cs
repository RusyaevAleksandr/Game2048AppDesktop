namespace Common
{
    internal class User
    {
        private string name = "User";

        private int score = 0;

        public string Name 
        { 
            get { return name; } 
            set { name = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public User(string name)
        {
            Name = name;
        }
    }
}
