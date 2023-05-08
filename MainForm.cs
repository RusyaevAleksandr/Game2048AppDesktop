using Game2048App.Common;
using Game2048WindowsForApp;
using Game2048WindowsFormApp;

namespace Game2048App
{
    public partial class MainForm : Form
    {
        private const int cellSpacing = 6;

        private const int cellSize = 80;

        private const int indentLeftAxisX = 10;

        private const int indentTopAxisY = 130;

        private readonly User user = new User("User");

        private readonly FileProvider fileProvider = new FileProvider();

        private Label[,] labelsMap;

        private int mapSize;        

        private int score = 0;

        private int bestScoreGame = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetSizeMainForm();

            user.Name = GetUserName();

            userLabel.Text = $"Игрок: {user.Name}";            

            CalculateBestScore();

            mapSize = GetDefaultMapSize();

            InitMap(mapSize);

            GenerateNumber(mapSize);

            ShowScore();
        }

        private void CalculateBestScore()
        {
            var users = UserRepository.GetUserResults();

            if (!FileProvider.Exists(fileProvider.NameFileResultGame))
            {
                ShowBestScore();
            }
            if (users.Count == 0)
            {
                return;
            }

            bestScoreGame = users.Where(u => u.MapSize == GetDefaultMapSize()).Max(u => u.Score);

            ShowBestScore();
        }

        private void ShowBestScore()
        {
            if(score > bestScoreGame)
            {
                bestScoreGame = score;
            }

            bestScoreLabel.Text = bestScoreGame.ToString();
        }

        private void ShowScore()
        {
            scoreLabel.Text = score.ToString();
        }

        private int GetDefaultMapSize()
        {
            if (StaticData.DataMapSize == 0)
            {
                mapSize = 4;
            }
            else
            {
                mapSize = StaticData.DataMapSize;
            }

            return mapSize;
        }

        private void GenerateNumber(int mapSize)
        {
            var random = new Random();  

            while (true)
            {
                var randomNumberLabel = random.Next(mapSize * mapSize);

                var indexRow = randomNumberLabel / mapSize;

                var indexColumn = randomNumberLabel % mapSize;

                if (labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    var randomNumber = random.Next(1, 101);

                    if(randomNumber <= 75)
                    {
                        labelsMap[indexRow, indexColumn].Text = "2";
                    }
                    else
                    {
                        labelsMap[indexRow, indexColumn].Text = "4";
                    }

                    break;
                }
            }
        }

        private void InitMap(int mapSize)
        {
            labelsMap = new Label[mapSize, mapSize];

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = NewCreateLabel(i, j);

                    Controls.Add(newLabel);

                    labelsMap[i, j] = newLabel;
                }
            }
        }
        private void GetSizeMainForm()
        {
            mapSize = GetDefaultMapSize();

            this.Width = (indentLeftAxisX * 2) + (mapSize * cellSize) + ((mapSize - 1) * cellSpacing);

            this.Height = indentTopAxisY + (mapSize * cellSize) + ((mapSize - 1) * cellSpacing) + indentLeftAxisX;

            this.ClientSize = new Size(this.Width, this.Height);
        }
        private Label NewCreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();

            int x = indentLeftAxisX + indexColumn * (cellSize + cellSpacing);
            int y = indentTopAxisY + indexRow * (cellSize + cellSpacing);
            label.Location = new Point(x, y);
            label.BackColor = Color.FromArgb(255, 248, 220);
            label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label.Size = new Size(cellSize, cellSize);
            label.TabIndex = 0;
            label.TextAlign = ContentAlignment.MiddleCenter;

            label.TextChanged += Label_TextChanged;

            return label;
        }

        private void Label_TextChanged(object? sender, EventArgs e)
        {
            var label = (Label)sender;

            switch (label.Text)
            {
                case "": label.BackColor = Color.FromArgb(255, 248, 220); break;
                case "2": label.BackColor = Color.FromArgb(245, 222, 179); break;
                case "4": label.BackColor = Color.FromArgb(255, 222, 173); break;
                case "8": label.BackColor = Color.FromArgb(222, 184, 135); break;
                case "16": label.BackColor = Color.FromArgb(218, 165, 32); break;
                case "32": label.BackColor = Color.FromArgb(184, 134, 11); break;
                case "64": label.BackColor = Color.FromArgb(205, 133, 63); break;
                case "128": label.BackColor = Color.FromArgb(210, 105, 30); break;
                case "256": label.BackColor = Color.FromArgb(160, 82, 45); break;
                case "512": label.BackColor = Color.FromArgb(139, 69, 19); break;
                case "1024": label.BackColor = Color.FromArgb(165, 42, 42); break;
                case "2048": label.BackColor = Color.FromArgb(128, 0, 0); break;
            }            
        }

        private string GetUserName()
        {
            if (StaticData.DataBufferUserName == String.Empty)
            {
                return $"User_{score}";
            }

            return StaticData.DataBufferUserName;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            mapSize = GetDefaultMapSize();

            if (Win())
            {
                user.Score = score;

                user.Name = GetUserName();

                user.MapSize = mapSize;

                UserRepository.AppendUserResult(user);

                MessageBox.Show("Вы Выиграли!!!");

                return;
            }
            if (EndGame())
            {
                user.Score = score;

                user.Name = GetUserName();

                user.MapSize = mapSize;

                UserRepository.AppendUserResult(user);

                MessageBox.Show("Игра закончилась! Вы проиграли!!!");

                return;
            }

            if (e.KeyCode != Keys.Right && e.KeyCode != Keys.Left && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
            {
                return;
            }

            #region Key Right
            if (e.KeyCode == Keys.Right)
            {
                MoveRight();
            }
            #endregion

            #region Key Left
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft();
            }
            #endregion

            #region Key Up
            if (e.KeyCode == Keys.Up)
            {
                MoveUp();
            }
            #endregion

            #region Key Down
            if (e.KeyCode == Keys.Down)
            {
                MoveDown();
            }
            #endregion

            GenerateNumber(mapSize);

            ShowScore();

            ShowBestScore();
        }

        private bool EndGame()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == "")
                    {
                        return false;
                    }
                }
            }

            for (int i = 0; i < mapSize - 1; i++)
            {
                for (int j = 0; j < mapSize - 1; j++)
                {
                    if (labelsMap[i, j].Text == labelsMap[i, j + 1].Text || labelsMap[i, j].Text == labelsMap[i + 1, j].Text)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool Win()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == "2048")
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void MoveDown()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    int number = int.Parse(labelsMap[i, j].Text);

                                    score += number * 2;

                                    labelsMap[i, j].Text = (number * 2).ToString();

                                    labelsMap[k, j].Text = string.Empty;
                                }

                                break;
                            }
                        }
                    }

                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;

                                labelsMap[k, j].Text = string.Empty;

                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveUp()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    int number = int.Parse(labelsMap[i, j].Text);

                                    score += number * 2;

                                    labelsMap[i, j].Text = (number * 2).ToString();

                                    labelsMap[k, j].Text = string.Empty;
                                }

                                break;
                            }
                        }
                    }

                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;

                                labelsMap[k, j].Text = string.Empty;

                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveLeft()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    int number = int.Parse(labelsMap[i, j].Text);

                                    score += number * 2;

                                    labelsMap[i, j].Text = (number * 2).ToString();

                                    labelsMap[i, k].Text = string.Empty;
                                }

                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;

                                labelsMap[i, k].Text = string.Empty;

                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveRight()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    int number = int.Parse(labelsMap[i, j].Text);

                                    score += number * 2;

                                    labelsMap[i, j].Text = (number * 2).ToString();

                                    labelsMap[i, k].Text = string.Empty;
                                }

                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;

                                labelsMap[i, k].Text = string.Empty;

                                break;
                            }
                        }
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void restartGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void rulesGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RulesGameForm rulesGameForm = new RulesGameForm();

            rulesGameForm.ShowDialog();
        }

        private void saveResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user.Score = score;

            user.Name = GetUserName();

            user.MapSize = mapSize;

            UserRepository.AppendUserResult(user);
        }

        private void resultListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultGameForm resultGameForm = new ResultGameForm();

            resultGameForm.ShowDialog();
        }
    }
}