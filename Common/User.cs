namespace Game2048App.Common
{
    public class User
    {
        private string name = "User";

        private int score;

        private int mapSize;

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

        public int MapSize
        {
            get { return mapSize; }
            set { mapSize = value; }
        }

        public User(string name)
        {
            Name = name;
            Score = 0;
            MapSize = 4;
        }
    }
}
