namespace Game2048App
{
    public partial class MainForm : Form
    {
        private Label[,] labelsMap;

        private const int mapSize = 4;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitMap();
        }

        private void InitMap()
        {
            labelsMap = new Label[mapSize, mapSize];

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = newCreateLabel(i, j, i * mapSize + j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }

        private Label newCreateLabel(int indexRow, int indexColumn, int number)
        {
            var label = new Label();
            int x = 10 + indexColumn * 76;
            int y = 70 + indexRow * 76;
            label.Location = new Point(x, y);
            //SuspendLayout();
            label.BackColor = SystemColors.ControlDark;
            label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label.Size = new Size(70, 70);
            label.TabIndex = 0;
            label.Text = number.ToString();
            label.TextAlign = ContentAlignment.MiddleCenter;
            return label;
        }
    }
}