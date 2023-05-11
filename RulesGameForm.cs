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
                rulesGame.Add("------------");
                rulesGame.Add("Как играть:");
                rulesGame.Add("* В начале игры вам выдается кирпичик с цифрой «2» или «4», нажимая кнопки на клавиатуре" +
                    " вверх, вправо, влево или вниз, все ваши плитки будут смещаться в ту же сторону.");
                rulesGame.Add("* После каждого смещения плиток, появляется новая плитка с цифрой «2» или «4» в случайном месте.");
                rulesGame.Add("* Вероятность появления плитки с цифрой «2» выше, чем плитки с цифрой «4».");
                rulesGame.Add("* При соприкосновении плиток с одним и тем же номиналом, они объединяются и создают сумму вдвое больше.");
                rulesGame.Add("* Если после последнего смещения плитки, нет свободных плиток без цифр и нет плиток с одинаковым номиналом, " +
                    "чтобы их объединить, игра заканчивается.");
                rulesGame.Add("* При завершении игры (проигрыш, победа), текущий результат (количество очков) автоматически сохраняются для указанного имени игрока.");
                rulesGame.Add("------------");
                rulesGame.Add("Рассмотрим на примере основное правило: ");
                rulesGame.Add("* Допустим, у Вас две плитки «2», сместите их так, чтобы они находились на одной линии по вертикали или горизонтали и нажмите стрелку," +
                    " чтобы объединить их, пока у вас не получиться цифра «4».");
                rulesGame.Add("* Дальше необходимо действовать тем же способом и теперь уже собирать плитку «8» из двух плиток «4».");
                rulesGame.Add("------------");
                rulesGame.Add("Управление:");
                rulesGame.Add("* Двигать плитки нужно с помощью клавиатуры. Стрелок: Вверх (Up), Вниз (Down), Влево (Left), Вправо (Right)");
                rulesGame.Add("* Для просмотра правил игры выберите пункт меню: Помощь => Правила игры.");
                rulesGame.Add("* Для просмотра результатов игры выберите пункт меню: Меню => Список результатов.");
                rulesGame.Add("* Для сохранения текущего результата игры выберите пункт меню: Меню => Сохранить результат.");
                rulesGame.Add("* Для того чтобы начать игру сначала выберите пункт меню: Меню => Начать сначала.");
                rulesGame.Add("* Для выхода из игры выберите пункт меню: Меню => Выход или нажмите на «Крестик» в правом верхнем углу окна игры.");
                rulesGame.Add("------------");
                rulesGame.Add("Элементы главного окна игры:");
                rulesGame.Add("* В верхней левой части главного окна игры отображается текущее имя игрока, введенное при запуске игры," +
                    " если пользователь не указал имя, по умолчанию будет присвоено имя «User_0».");
                rulesGame.Add("* Если не было указано имя игрока, в результатах вместо имени будет сохранено «User_» и количество очков текущей игры.");
                rulesGame.Add("* Ниже имени игрока отображается текущее количество очков.");
                rulesGame.Add("* В верхней правой части главного окна игры отображается рекорд, максимально набранное количество очков для данного размера поля.");
                rulesGame.Add("* Если игрок наберет количество очков больше чем рекорд для данного размера поля, в поле рекорд автоматически отобразится текущее значение очков.");

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
                rulesGameListBox.Items.Add(rulesGame[i]);
            }
        }
    }
}
