using Game2048App.Common;

namespace Game2048WindowsFormApp
{
    public partial class ResultGameForm : Form
    {
        private List<User> users = new List<User>();

        public ResultGameForm()
        {
            InitializeComponent();
        }

        private void ResultGameForm_Load(object sender, EventArgs e)
        {
            users = UserRepository.GetUserResults();

            var sortUsersForBestScore = users.OrderByDescending(x => x.Score).ToList();

            var maxValue = users.Max(x => x.Score);

            var bestScore = users.Where(x => x.Score == maxValue);

            StaticData.DataBufferUserScore = bestScore.ToString();

            foreach (User user in sortUsersForBestScore)
            {
                resultGameDataGridView.Rows.Add(user.Name, user.Score);
            }
        }
    }
}
