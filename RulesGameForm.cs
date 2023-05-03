using Game2048App.Common;
using Newtonsoft.Json;

namespace Game2048WindowsForApp
{
    public partial class RulesGameForm : Form
    {
        private static FileProvider fileProvider = new FileProvider();

        private List<string> rulesGame;

        private static List<string> GetRulesGame()
        {
            List<string> rulesGame = new List<string>();

            if (!FileProvider.Exists(fileProvider.NameFileRulesGame))
            {
                rulesGame.Add("Цель игры — собрать плитку с цифрами 2048.");
                rulesGame.Add("Как играть:");
                rulesGame.Add("* В начале игры вам выдается кирпичик с цифрой «2» или «4», нажимая кнопки на клавиатуре" +
                    " вверх, вправо, влево или вниз, все ваши плитки будут смещаться в ту же сторону.");
                rulesGame.Add("* После каждого смещения плиток, появляется новая плитка с цифрой «2» или «4» в случайном месте.");
                rulesGame.Add("* Вероятность появления плитки с цифрой «2» выше, чем плитки с цифрой «4».");
                rulesGame.Add("* При соприкосновении плиток с одним и тем же номиналом, они объединяются и создают сумму вдвое больше.");
                rulesGame.Add("* Если после последнего смещения плитки, нет свободных плиток без цифр и нет плиток с одинаковым номиналом, " +
                    "чтобы их объединить, игра заканчивается.");
                rulesGame.Add("Рассмотрим на примере основное правило: ");
                rulesGame.Add("* Допустим, у Вас две плитки «2», сместите их так, чтобы они находились на одной линии по вертикали или горизонтали и нажмите стрелку," +
                    " чтобы объединить их, пока у вас не получиться цифра «4».");
                rulesGame.Add("* Дальше необходимо действовать тем же способом и теперь уже собирать плитку «8» из двух плиток «4».");

                SaveRulesGame(rulesGame);
            }

            var fileData = FileProvider.GetValue(fileProvider.NameFileRulesGame);

            rulesGame = JsonConvert.DeserializeObject<List<string>>(fileData);

            return rulesGame;
        }
        private static void SaveRulesGame(List<string> rulesGame)
        {
            var jsonData = JsonConvert.SerializeObject(rulesGame, Formatting.Indented);

            FileProvider.Replace(fileProvider.Path, fileProvider.NameFileRulesGame, jsonData);
        }

        public RulesGameForm()
        {
            InitializeComponent();
        }
        private void RulesGameForm_Load(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(fileProvider.Path);

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            rulesGame = GetRulesGame();

            for (int i = 0; i < rulesGame.Count; i++)
            {
                ListViewItem listView = new ListViewItem();

                listView.Text = rulesGame[i];

                rulesGameListView.Items.Add(listView);
            }
        }
    }
}
