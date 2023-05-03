using Game2048App.Common;
using Game2048WindowsForApp;
using Game2048WindowsFormApp;

namespace Game2048App
{
    public partial class MainForm : Form
    {
        private Label[,] labelsMap;

        private int mapSize;

        private const int cellSpacing = 6;

        private const int cellSize = 80;

        private const int indentLeftAxisX = 10;

        private const int indentTopAxisY = 130;

        private static Random random = new Random();

        private int score = 0;

        private User user = new User("User");

        private FileProvider fileProvider = new FileProvider();

        private int bestScoreGame = 0;

        private bool valueChanged = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetSizeMainForm();

            user.Name = StaticData.DataBufferUserName;

            userLabel.Text = $"Игрок: {user.Name}";

            var users = UserRepository.GetUserResults();

            if (!FileProvider.Exists(fileProvider.NameFileResultGame))
            {
                bestScoreLabel.Text = bestScoreGame.ToString();
            }
            else
            {
                bestScoreGame = users.Max(u => u.Score);

                bestScoreLabel.Text = bestScoreGame.ToString();
            }

            mapSize = GetDefaultMapSize();

            InitMap(mapSize);

            GenerateNumber(mapSize);

            ShowScore();
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
            while (true)
            {
                var randomNumberLabel = random.Next(mapSize * mapSize);

                var indexRow = randomNumberLabel / mapSize;

                var indexColumn = randomNumberLabel % mapSize;

                if (labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    labelsMap[indexRow, indexColumn].Text = MainLogicApp.ShowRandomNumber();

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
            label.BackColor = GetColorField(valueChanged);
            label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label.Size = new Size(cellSize, cellSize);
            label.TabIndex = 0;
            label.TextAlign = ContentAlignment.MiddleCenter;
            return label;
        }

        private Label ShowNewColorLabel(int locationX, int locationY)
        {
            var labelNewColor = new Label();

            var label = new Label();
            label.Location = new Point(locationX, locationY);
            label.BackColor = GetColorField(valueChanged);
            label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label.Size = new Size(cellSize, cellSize);
            label.TabIndex = 0;
            label.TextAlign = ContentAlignment.MiddleCenter;

            return labelNewColor;
        }

        private Color GetColorField(bool valueChanged)
        {
            var color = new Color();

            int numberRed = 255;

            int numberGreen = 248;

            int numberBlue = 220;

            if (valueChanged)
            {
                numberRed -= 2;
                numberGreen -= 2;
                numberBlue -= 2;
            }

            color = Color.FromArgb(numberRed, numberGreen, numberBlue);

            return color;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            mapSize = GetDefaultMapSize();

            #region Key Right
            if (e.KeyCode == Keys.Right)
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
            #endregion

            #region Key Left
            if (e.KeyCode == Keys.Left)
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
            #endregion

            #region Key Up
            if (e.KeyCode == Keys.Up)
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
            #endregion

            #region Key Down
            if (e.KeyCode == Keys.Down)
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

                                        labelsMap[i, j].Text = (number * 2).ToString()

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
            #endregion

            GenerateNumber(mapSize);

            ShowScore();
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

            UserRepository.AppendUserResult(user);
        }

        private void resultListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultGameForm resultGameForm = new ResultGameForm();

            resultGameForm.ShowDialog();
        }
    }
}